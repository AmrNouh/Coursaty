using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseDemo.Core.Models
{
    public class CourseRequiredSkill
    {
        [ForeignKey("Course")]
        public Guid CourseId { get; set; }

        [ForeignKey("Skill")]
        public Guid SkillId { get; set; }

        //Nav Properties
        public Course Course { get; set; }
        public Skill Skill { get; set; }
    }
}
