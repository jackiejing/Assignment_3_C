using Assignment3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.DataModel
{
    public class Department : IDepartment
    {
        public string Headname { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public void PrintCourse()
        {
            string[] coursename = new string[10];
            foreach (var item in coursename)
            {
                Console.WriteLine(item);
            }

        }
    }
}
