using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApps.Models;

namespace StudentApps.Data
{
    public class StudentsAppsContext : DbContext
    {
        public StudentsAppsContext (DbContextOptions<StudentsAppsContext> options)
            : base(options)
        {
        }

        public DbSet<StudentApps.Models.Student> Students { get; set; }
    }
}
