using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Lab Name!!!");
                }
                else
                {
                    this.town = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("OffsiteCourse: ");
            output.Append(base.ToString());
            if (this.Town != null)
            {
                output.AppendFormat("; Town={0}", this.Town);
            }

            return output.ToString();
        }
    }
}
