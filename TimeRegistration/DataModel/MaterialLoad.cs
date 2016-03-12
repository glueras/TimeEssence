using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration
{
    public class MaterialLoad : Load
    {
        private Material _material;

        public Material Material
        {
            get { return _material; }
            set { _material = value; }
        }

    }
}
