using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//course
class CourseController : Controller {
    //course/index
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "Güzel bir kurs";

        return View(kurs);
    }
    //course/list
        public IActionResult List()
    {
        var kurslar = new List<Course>()
        {
            new Course() {Id = 1, Title = "aspnet kursu", Description = "güzel bir kurs"},
            new Course() {Id = 2, Title = "php kursu", Description = "güzel bir kurs"},
            new Course() {Id = 3, Title = "djungo kursu", Description = "güzel bir kurs"}

        };
        return View("CourseList, kurslar");
    }

}