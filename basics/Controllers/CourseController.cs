using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//course
class CourseController : Controller {
    //course/index
    public IActionResult Index()
    {
        return View();
    }
    //course/list
        public IActionResult List()
    {
        return View("CourseList");
    }

}