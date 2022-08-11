using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseDemo.Core.Models
{
    public class CourseModule
    {
        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        [ForeignKey("Module")]
        public Guid ModuleId { get; set; }

        //Nav Prorperties
        public Course Course { get; set; }
        public Module Module { get; set; }
    }
}
