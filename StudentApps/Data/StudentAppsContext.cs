using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApps.Models;

namespace StudentApps.Data
{
    public class StudentAppsContext : DbContext
    {
        public StudentAppsContext (DbContextOptions<StudentAppsContext> options)
            : base(options)
        {
        }

        public DbSet<StudentApps.Models.Student> Student { get; set; }
    }
}
