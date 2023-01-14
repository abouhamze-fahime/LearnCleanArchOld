using ApplicationCore.Interfaces;
using ApplicationCore.ViewModels;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUI.Controllers
{
    public class HomeController : Controller
    {
        private ICourseService _courseService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
           CourseViewModel Cmodel= _courseService.GetAllCourse();
            return View(Cmodel);
        }

        public IActionResult ShowCourseDetail(int id)
        {
            Course course = _courseService.GetCourse(id);
            return View(course);
        }

      
    }
}
