using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseDemo.Core.Models
{
    public class Module
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Module Name Is Required")]
        public string Name { get; set; }

        // Nav Properties
        public ICollection<CourseModule> CourseModules { get; set; }

        public Module()
        {
            CourseModules = new List<CourseModule>();
        }
    }
}
