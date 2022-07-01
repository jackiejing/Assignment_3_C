using Assignment3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public class Student : Person, IStudentService
    {
        public int Totalcourse { get; set; }
        public string _StudentId { get; set; }
        public string _SchoolName { get; set; }
        public void sName()
        {
            _SchoolName = "Antra";
        }


        public void situation(string sit)
        {
            Console.WriteLine($"I'm doing {sit}");
        }

        public string[] coursesName(int total)
        {
            string[] courses = new string[total];
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write("enter coursename: ");
                courses[i] = Console.ReadLine();
            }
            return courses;

        }

        public double Gpa()
        {
            Console.WriteLine("for gpa caluate");
            return -1;
        }
    }
}
