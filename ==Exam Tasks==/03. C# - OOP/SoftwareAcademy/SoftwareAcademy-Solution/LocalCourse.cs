using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Lab Name!!!");
                }
                else
                {
                    this.lab = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("LocalCourse: ");
            output.Append(base.ToString());
            if (this.Lab != null)
            {
                output.AppendFormat("; Lab={0}", this.Lab);
            }
            
            return output.ToString();
        }
    }
}
