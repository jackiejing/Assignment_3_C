using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repository
{
    public interface ICourseService
    {
        public string[] StudentList(int total);
    }
}
