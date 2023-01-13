using ApplicationCore.Interfaces;
using ApplicationCore.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services
{
    public class CourseServices : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetAllCourse()
            };
        }
    }
}
