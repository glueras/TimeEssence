using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class Vehicle
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _licensePlate;

        public string LicensePlate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
    }
}
