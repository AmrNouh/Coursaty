using CourseDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesDemo.Models
{
    public class CourseListViewModel
    {

        public List<Course> Courses { get; set; }
        public List<Category> Categories { get; set; }
        public List<Module> Modules { get; set; }
        public List<Level> Levels { get; set; }
        

        public CourseListViewModel()
        {
            Courses = new List<Course>();
            Categories = new List<Category>();
            Modules = new List<Module>();
            Levels = new List<Level>();
        }
    }
}
