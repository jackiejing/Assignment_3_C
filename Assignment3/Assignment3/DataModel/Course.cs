using Assignment3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public class Course : ICourseService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void cId()
        {
            Id = 101;
        }

        public string[] StudentList(int total)
        {
            string[] students = new string[total];
            for (int i = 0; i < total; i++)
            {
                Console.Write("enter coursename: ");
                students[i] = Console.ReadLine();
            }
            return students;
        }
    }
}
