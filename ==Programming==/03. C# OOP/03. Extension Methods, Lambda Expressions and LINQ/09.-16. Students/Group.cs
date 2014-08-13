using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._16.Students
{
    public class Group
    {
        //Fields
        private int groupNumber;
        private string departmentName;

        //Constructor
        public Group(int groupNumber, string groupName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = groupName;
        }

        //Properties
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The group number must be positive!!!");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The Group Name must be 3 or more characters");
                }
                else
                {
                    this.departmentName = value;
                }
            }
        }
    }
}
