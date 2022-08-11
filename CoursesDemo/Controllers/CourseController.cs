using CourseDemo.Core.Models;
using CourseDemo.Core.Repositories;
using CoursesDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoursesDemo.Controllers
{
    public class CourseController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public CourseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            CourseListViewModel courseListViewModel = new CourseListViewModel()
            {
                Courses = (List<Course>)unitOfWork.Courses.GetAll(),
                Categories = (List<Category>)unitOfWork.Categories.GetAll(),
                Modules = (List<Module>)unitOfWork.Modules.GetAll(),
                Levels = (List<Level>)unitOfWork.Levels.GetAll(),
            };

            return View(courseListViewModel);
        }

        [HttpGet]
        public IActionResult New()
        {
            return PartialView("_AddCourse", new AddCourseViewModel()
            {
                Categories = (List<Category>)unitOfWork.Categories.GetAll(),
                Types = (List<CourseType>)unitOfWork.Types.GetAll(),
                Levels = (List<Level>)unitOfWork.Levels.GetAll(),
                Currencies = (List<Currency>)unitOfWork.Currencies.GetAll(),
                Languages = (List<Language>)unitOfWork.Languages.GetAll(),
                Statuses = (List<Status>)unitOfWork.Statuses.GetAll(),
                Skills = (List<Skill>)unitOfWork.Skills.GetAll(),
                Modules = (List<Module>)unitOfWork.Modules.GetAll(),
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCourse(AddCourseViewModel newCourse)
        {
            if (!ModelState.IsValid)
                return PartialView("_AddCourse", newCourse);

            return RedirectToAction("index");
        }
    }
}
