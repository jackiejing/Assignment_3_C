using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repository
{
    public interface IInstructorService
    {
        public int BounsJoin(DateTime join);
        public bool HeadDepartment(int workdays);
    }
}
