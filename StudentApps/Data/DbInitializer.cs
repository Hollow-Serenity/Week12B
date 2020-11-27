using StudentApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApps.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StudentAppsContext context)
        {
            if (context.Student.Any()) return;
            context.Student.Add(new Student { StudentNo = 19140576, FirstName = "Dino", LastName = "Cosic", BirthDay = "06-01-1996", Email = "19140576@student.hhs.nl", Phonenumber = 0612345671 });
            context.Student.Add(new Student { StudentNo = 19140577, FirstName = "Piet", LastName = "Pietersen", BirthDay = "21-09-1997", Email = "19140577@student.hhs.nl", Phonenumber = 0612345672 });
            context.Student.Add(new Student { StudentNo = 19140578, FirstName = "Jan", LastName = "Janssen", BirthDay = "26-08-1998", Email = "19140578@student.hhs.nl", Phonenumber = 0612345673 });
            context.Student.Add(new Student { StudentNo = 19140579, FirstName = "Joost", LastName = "Groot", BirthDay = "30-07-1999", Email = "19140579@student.hhs.nl", Phonenumber = 0612345674 });
            context.Student.Add(new Student { StudentNo = 19140570, FirstName = "Mary", LastName = "Boon", BirthDay = "11-06-2000", Email = "19140570@student.hhs.nl", Phonenumber = 0612345675 });
            context.SaveChanges();
        }
    }
}
