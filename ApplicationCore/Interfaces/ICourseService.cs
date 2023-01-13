using ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
   public interface ICourseService
    {
        CourseViewModel GetAllCourse();
    }
}
