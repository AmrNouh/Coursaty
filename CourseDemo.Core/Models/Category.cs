using System;
using System.ComponentModel.DataAnnotations;

namespace CourseDemo.Core.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Category Name Is Required")]
        public string Name { get; set; }
    }
}
