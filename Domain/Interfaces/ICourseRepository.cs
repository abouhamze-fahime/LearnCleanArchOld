using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
  public  interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourse();
        Course GetCourse(int id);

    }
}
