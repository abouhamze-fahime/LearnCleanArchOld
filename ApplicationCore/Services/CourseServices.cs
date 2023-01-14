using ApplicationCore.Interfaces;
using ApplicationCore.ViewModels;
using Domain.Interfaces;
using Domain.Models;
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
        public CourseViewModel GetAllCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetAllCourse()
            };
        }

        public Course GetCourse(int id)
        {
            return _courseRepository.GetCourse(id);
        }
    }
}
