using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repository
{
    public interface IPersonService
    {
        public int CalAge(int birthyear);
        public decimal salary(int hour);
        public string getaddress(string add);
    }
}
