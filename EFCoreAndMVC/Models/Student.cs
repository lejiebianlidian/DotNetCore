using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreAndMVC.Models
{
    public class Student
    {
        public int id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public  MyProperty { get; set; }



    }
}
