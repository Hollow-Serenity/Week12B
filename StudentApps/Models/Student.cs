using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApps.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "StudentenNummer")]
        [Required]
        [RegularExpression(@"^(\d{8})$", ErrorMessage = "Student number must be 8 characters.")]

        public int StudentNo { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string BirthDay { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public int Phonenumber { get; set; }

        public List<Student> Vrienden = new List<Student>();

    }
}
