using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class Project
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private string _customerId;

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        private IList<MaterialLoad> _materialLoads;

        public IList<MaterialLoad> MaterialLoads
        {
            get { return _materialLoads; }
            set { _materialLoads = value; }
        }

        private IList<WorkLoad> _workLoads;

        public IList<WorkLoad> Workloads
        {
            get { return _workLoads; }
            set { _workLoads = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _state;

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }

        private DateTime _created;

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        private DateTime? _ended;

        public DateTime? Ended
        {
            get { return _ended; }
            set { _ended = value; }
        }

        private IList<string> _files;

        public IList<string> Files
        {
            get { return _files; }
            set { _files = value; }
        }

    }
}
