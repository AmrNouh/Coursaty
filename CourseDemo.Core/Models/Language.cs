using System;
using System.ComponentModel.DataAnnotations;

namespace CourseDemo.Core.Models
{
    public class Language
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Language Name Is Required")]
        public string Name { get; set; }
    }
}
