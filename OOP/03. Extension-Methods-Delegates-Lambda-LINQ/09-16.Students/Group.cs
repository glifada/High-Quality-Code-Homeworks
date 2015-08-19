using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19.Students
{
    class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int group, string department)
        {
            this.GroupNumber = group;
            this.DepartmentName = department;
        }

        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }
    }
}
