using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class Material
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _picture;

        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        private string _unitType;

        public string UnitType
        {
            get { return _unitType; }
            set { _unitType = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

    }
}
