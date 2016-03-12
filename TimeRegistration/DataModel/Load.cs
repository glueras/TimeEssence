using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class Load
    {
        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private DateTime _added;

        public DateTime Added
        {
            get { return _added; }
            set { _added = value; }
        }

        private int _sortType;

        public int SortType
        {
            get { return _sortType; }
            set { _sortType = value; }
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
