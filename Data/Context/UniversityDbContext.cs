using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
   public class UniversityDbContext :DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options):base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
