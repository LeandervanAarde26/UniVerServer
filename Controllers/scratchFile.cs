namespace UniVerServer.Controllers;

public class scratchFile
{
    // TODO: CREATE SEPERATE CONTROLLER/S
    
    //         [HttpGet("studentFees")]
//         public async Task<ActionResult<CourseEnrollments>> GetAllStudentFees()
//         {
//             if (_context.Courses == null)
//             {
//                 return NotFound();
//             }
//             var data = await (from enrollment in _context.Courses
//                               join learner in _context.People
//                               on enrollment.student_id equals learner.person_system_identifier
//                               join subject in _context.Subjects
//                               on enrollment.Subjects equals subject.subject_id
//                               join lecturer in _context.People
//                               on subject.lecturer_id equals lecturer.person_id
//                               join role in _context.Roles
//                               on lecturer.role equals role.role_id
//                               select new CourseEnrollmentView
//                               {
//                                 
//                                   student_id = learner.person_id,
//                                   student_name = learner.first_name + " " + learner.last_name,
//                                   student_systemIdentifier = learner.person_system_identifier,
//                                   student_number = learner.person_cell,
//                                   student_email = learner.person_email,
//                                   student_credits = learner.person_credits,
//                                   student_needed_credits = learner.needed_credits,
//                                   subject_description = subject.subject_description,
//
//                                   subject_id = subject.subject_id,
//                                   subject_name = subject.subject_name,
//                                   subject_cost = subject.subject_cost,
//                                   subject_credits = subject.subject_credits,
//                                   subject_runtime = subject.subject_class_runtiem,
//                               
//                               }
//                          ).ToListAsync();
//
//             var result = data
//                             .GroupBy(item => item.student_name)
//                             .Select(group => new StudentPayment
//                             {
//
//                                 student = group.Key,
//                                 studentId = group.ToList()[0].student_id,
//                                 studentNumber = group.ToList()[0].student_systemIdentifier,
//                                 credits = group.ToList()[0].student_credits,
//                                 //courses = group.ToList(),
//                                 studentYearlyFee = group.Sum(item =>
//                                 {
//                                     return item.subject_cost;
//                                 }),
//                                 studentMonthlyFee = group.Sum(item =>
//                                 {
//                                     return item.subject_cost;
//                                 }
//                                 ) / 12 ,
//                                 aquiredCredits = group.Sum(item =>
//                                 {
//                                     return item.student_credits;
//                                 })
//                             });
//             return Ok(result);
//         }


//         [HttpGet("lecturerfees")]
//         public async Task<ActionResult<CollectiveLecturerSalary>> GetAllLecturerFees()
//         {
//             if (_context.Subjects == null)
//             {
//                 return NotFound();
//             }
//      
//             var lecturersPayment = await (from subject in _context.Subjects
//                                      join lecturer in _context.People
//                                      on subject.lecturer_id
//                                      equals lecturer.person_id
//                                      join role in _context.Roles
//                                      on lecturer.role equals role.role_id                      
//                                      select new LecturerPayment
//                                      {
//                                         subject_id = subject.subject_id,
//                                         subject_name = subject.subject_name,
//                                         lecturer_id = lecturer.person_id,
//                                         lecturer = lecturer.first_name + " " + lecturer.last_name,
//                                         subject_class_amount = subject.subject_class_amount,
//                                         course_start = subject.course_start,
//                                         class_time = subject.subject_class_runtiem,
//                                         monthlyIncome = Math.Round((subject.subject_class_amount * (subject.subject_class_runtiem/60)) * (((decimal)subject.course_start.Day / new DateTime(subject.course_start.Year, subject.course_start.Month, DateTime.DaysInMonth(subject.course_start.Year, subject.course_start.Month)).Day) * role.rate), 2),
//                                         hoursWorked = Math.Round((subject.subject_class_amount * (subject.subject_class_runtiem / 60)) * (((decimal)subject.course_start.Day / new DateTime(subject.course_start.Year, subject.course_start.Month, DateTime.DaysInMonth(subject.course_start.Year, subject.course_start.Month)).Day)), 2)
//                                      })
//                                       .ToListAsync();
//
//                 var result = lecturersPayment
//                              .GroupBy(item => item.lecturer)
//                              .Select(group => new CollectiveLecturerSalary
//                              {
//                                 lecturerId = group.ToList()[0].lecturer_id,
//                                 lecturer = group.Key,
//                                 //subjects = group.ToList(),
//                                 totalHoursWorked = group.Sum(item =>
//                                 {
//                                     return item.hoursWorked;
//                                 }),
//                                 monthlyIncome = group.Sum(item =>
//                                 {
//                                     return item.monthlyIncome;
//                                 })
//                             })
//                              .ToList();
//
//             return Ok(result);
//         }


    // [HttpGet("AdminFees")] 
    // public async Task<ActionResult<People>> GetAdminSalary()
    // {
    //     if(_context.People == null)
    //     {
    //         return StatusCode(StatusCodes.Status500InternalServerError);
    //     }
    //
    //     var adminFees = await (from admin in _context.People
    //                            join role in _context.Roles
    //                            on admin.role equals role.role_id
    //                            where admin.role == 1
    //                            select new
    //                            {
    //                                admin_id = admin.person_id,
    //                                admin_name = admin.first_name + " " + admin.last_name,
    //                                admin_payment = role.rate,
    //
    //                            }).ToListAsync();
    //
    //
    //     if(adminFees ==  null)
    //     {
    //         return NotFound();
    //     }
    //
    //
    //     return Ok(adminFees);
    // }
    //
    
    
    // [HttpGet()]
    // public async Task<ActionResult<People>> GetLoggedInUser(int userId)
    // {
    //     if (_context.People == null)
    //     {
    //         return StatusCode(StatusCodes.Status500InternalServerError);
    //     }
    //
    //     if(int.IsNegative(userId) || userId == null)
    //     {
    //         return BadRequest("Invalid request parameters");
    //     }
    //
    //     var user = await _context.People.SingleOrDefaultAsync(p => p.person_id.Equals(userId));
    //
    //     if (user == null)
    //     {
    //         return NotFound("User not found on database");
    //     }
    //
    //     return user;
    // }
    //

    
    // [HttpPost("auth")]
    // public async Task<ActionResult<AuthenticatedUser>> AuthenticateUser([FromBody] Authentication request)
    // {
    //     if(string.IsNullOrEmpty(request.email) || string.IsNullOrEmpty(request.password))
    //     {
    //         return BadRequest("Parameters to request can not be empty or Null");
    //     }
    //     // To lower not working now?
    //     var person = await _context.People.SingleOrDefaultAsync(p => p.person_email.Equals(request.email));
    //
    //     if (person == null || person.person_active == false)
    //     {
    //         return NotFound();
    //     }
    //
    //     AuthenticatedUser formattedPerson = new()
    //     {
    //         user_id = person.person_id,
    //         username = $"{person.first_name} {person.last_name}",
    //         userEmail = person.person_email
    //     };
    //
    //     if (formattedPerson == null)
    //     {
    //         return StatusCode(StatusCodes.Status500InternalServerError);
    //     }
    //
    //     var roles = await _context.Roles.SingleOrDefaultAsync(p => p.role_id.Equals(person.role));
    //
    //     var isAuthenticated = ValidateUserCredentials(person.person_password, request.password, request.email);
    //
    //     if (!isAuthenticated || !roles!.can_access || !person.person_active)
    //     {
    //         return Unauthorized();
    //     }
    //     return Ok(formattedPerson);
    // }
    //

}