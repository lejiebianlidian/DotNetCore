using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreAndMVC.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public string CourseId { get; set; }

        public string StudentId { get; set; }

        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student  Student { get; set; }



    }
}
