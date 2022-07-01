using Assignment3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public class Instructor : Person, IInstructorService
    {
        public Instructor(int id, string name, string departmentName, int salary)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentName;
            Salary = salary;

        }
        public string DepartmentName { get; set; }
        public int Salary { get; set; }
        public int _InstructorId { get; set; }

        public void situation(int a)
        {
            Console.WriteLine($"{a}% of day is happy");
        }

        public int BounsJoin(DateTime join)
        {
            DateTime current = DateTime.Now;
            TimeSpan result = current.Subtract(join);
            int total = (int)result.TotalDays;
            return total;
        }

        public bool HeadDepartment(int workyear)
        {
            if (workyear >= 25)
            {
                return true;
            }
            return false;
        }
    }
}
