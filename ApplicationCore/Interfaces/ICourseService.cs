using ApplicationCore.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
   public interface ICourseService
    {
        CourseViewModel GetAllCourse();
        Course GetCourse(int id);
    }
}
