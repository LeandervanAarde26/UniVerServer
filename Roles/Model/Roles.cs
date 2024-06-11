﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UniVerServer.Abstractions;

namespace UniVerServer.Roles.Models;

    [Table("Roles")]
    public class Roles : BaseModel
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public bool CanAccess { get; set; } = false;
        [Required]
        public bool PaidRole { get; set; }
        public decimal HourlyRate { get; set; }
    }
