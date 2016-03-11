using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class InvoiceModel
    {
        public string Id { get; set; }
        public CustomerModel Customer { get; set; }
        public List<EmployeeModel> Employees { get; set; }
        public string Location { get; set; }
        public double Duration { get; set; }
        public List<MaterialModel> Materials { get; set; }

    }
}
