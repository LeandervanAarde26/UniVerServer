﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using UniVerServer;
using UniVerServer.Models;

namespace UniVerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // I made this a post request so that the password is not visible in the request URL 
        [HttpPost("/auth")]
        public async Task<ActionResult<PersonDataObject>> AuthenticateUser([FromBody] Authentication request)
        {
            var person = await _context.People.Include(p => p.role).Where(p => p.person_email.Equals(request.email)).FirstOrDefaultAsync();

            if (person == null || person.person_active == false)
            {
                return NotFound();
            }

            if (person.person_password != request.password
                || request.password == null
                || person.person_email != request.email
                || person.role_id != 1)
            {
                return Unauthorized();
            }
            var personDataObject = new PersonDataObject
            {
                person_id = person.person_id,
                person_system_identifier = person.person_system_identifier,
                first_name = person.first_name,
                last_name = person.last_name,
                person_email = person.person_email,
                person_active = person.person_active,
                role = person.role,
            };
            return personDataObject;
        }
        //TODO IN AUTh: 
        // 1. Decrypt passwords 
        // 2. When creating an account, passwords should be encrypted 
        // 3. Create session Tokens for each user.

        // ==== end authentication
        // GET: api/People
        // Get all people
        [HttpGet]
        public async Task<ActionResult<IEnumerable<People>>> GetPeople()
        {
          if (_context.People == null)
          {
              return NotFound();
          }
          
          var relationalData = await _context.People.Include(p => p.role).Include(p => p.Address).ToListAsync();

          if (relationalData == null)
          {
            return NotFound();
          }
          return relationalData;
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<People>> GetPeople(int id)
        {
          if (_context.People == null)
          {
              return NotFound();
          }
            var people = await _context.People.FindAsync(id);

            if (people == null)
            {
                return NotFound();
            }

            return people;
        }

        //GET: Get person by role 
        [HttpGet("role/{role}")]
        public async Task<ActionResult<People>> GetPeopleWithRole(int role)
        {
            if (_context.People == null)
            {
                return NotFound();
            }
            var people = await _context.People.Include(p => p.role).Where(p => p.role.role_id == role).Include(p => p.Address).ToListAsync();

            if (people == null)
            {
                return NotFound();
            }

            return Ok(people);
        }


        // PUT: api/People/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeople(int id, People people)
        {
            if (id != people.person_id)
            {
                return BadRequest();
            }

            _context.Entry(people).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/People
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<People>> PostPeople(People people)
        {
          if (_context.People == null)
          {
              return Problem("Entity set 'ApplicationDbContext.People'  is null.");
          }
            _context.People.Add(people);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeople", new { id = people.person_id }, people);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeople(int id)
        {
            if (_context.People == null)
            {
                return NotFound();
            }
            var people = await _context.People.FindAsync(id);
            if (people == null)
            {
                return NotFound();
            }

            _context.People.Remove(people);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PeopleExists(int id)
        {
            return (_context.People?.Any(e => e.person_id == id)).GetValueOrDefault();
        }
    }
}