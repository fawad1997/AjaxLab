using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxLab.Models
{
    public class Course
    {
        [Required]
        [RegularExpression("^[a-zA-Z]{2}[0-9]{4}")]
        public string CourseCode { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
    }
}