using System;
using System.ComponentModel.DataAnnotations;

namespace CourseDemo.Core.Models
{
    public class Currency
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Currency Name Is Required")]
        public string Name { get; set; }
    }
}
