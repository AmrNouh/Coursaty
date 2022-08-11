using System;
using System.ComponentModel.DataAnnotations;

namespace CourseDemo.Core.Models
{
    public class CourseType
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Type Name Is Required")]
        public string Name { get; set; }
    }
}
