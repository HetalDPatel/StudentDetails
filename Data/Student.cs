///***********************
///Model Class For the App
///
/// Error: To be resolved
/// 1.) StudentId- it takes duplicate value- refer to the StudentIdValidator Class
/// 
/// 
/// </summary>
///***********************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentsDetails.Data
{
    public class Student
    {
      

        public int StudentId { get; set; }
        public static int Id { get; set; }

        public Student()
        {

            StudentId = (Id++) - 1;

        }

        [Required]
        [RequiredDataValidator(ErrorMessage = "FirstName should be 2-16 character long and should be string")]
        public string FirstName { get; set; }

        [Required]
        [RequiredDataValidator(ErrorMessage = "Lastname should be 2-16 character long and should be string")]
        public string LastName { get; set; }

        [Required]
        [RequiredDataValidator(ErrorMessage = "School Name should be 2-16 character long and should be string")]
        public string SchoolName { get; set; }

        [Required]
        [RequiredDataValidator(ErrorMessage = "City Name should be 2-16 character long and should be string")]
        public string City { get; set; }
        
        [Required]
        [RequiredDataValidator(ErrorMessage = "Province should be 2-16 character long and should be string")]
        public string Province { get; set; }

      
    }
}
