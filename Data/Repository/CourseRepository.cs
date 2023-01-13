using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _context;
        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetAllCourse()
        {
            return _context.Course;
        }

        public Course GetCourse()
        {
            throw new NotImplementedException();
        }
    }
}
