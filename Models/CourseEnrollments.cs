﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniVerServer.Models
{
    [Table("course_enrollments")]
    public class CourseEnrollments
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollment_id { get; set; }

        [ForeignKey("person_system_identifier")]
        [Required]
        public string student_id { get; set; }   

        [ForeignKey("subject_id")]
        [Required]
        public int Subjects { get; set; }

        public static explicit operator List<object>(CourseEnrollments? v)
        {
            throw new NotImplementedException();
        }
    }
}
