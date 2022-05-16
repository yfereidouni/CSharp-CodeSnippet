using iCourseStore.NLayer.BLL;
using Microsoft.AspNetCore.Mvc;

namespace iCourseStore.Endpoints.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly CourseServices courseServices;

        public HomeController(ILogger<HomeController> logger, CourseServices courseServices)
        {
            this.logger = logger;
            this.courseServices = courseServices;
        }

        public IActionResult Index()
        {
            var courses = courseServices.GetAllCourse();
            return View(courses);
        }
    }
}
