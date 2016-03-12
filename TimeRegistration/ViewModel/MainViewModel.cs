using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRegistration.ViewModel
{
    public class MainViewModel
    {
        private IList<Project> _projects;

        public IList<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }

    }
}
