using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class WorkLoad : Load
    {
        private Employee _employee;

        public Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
    }
}
