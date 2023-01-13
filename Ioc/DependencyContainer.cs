using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ioc
{
   public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service , IConfiguration configuration)
        {
            service.AddScoped<ICourseService, CourseServices>();
            service.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
