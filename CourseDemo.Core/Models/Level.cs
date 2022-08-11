using System;
using System.ComponentModel.DataAnnotations;

namespace CourseDemo.Core.Models
{
    public class Level
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Level Name Is Required")]
        public string Name { get; set; }
    }
}
