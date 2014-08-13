using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name can't be missing!");
                }
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (9999 < value && value < 100000)
                {
                    this.uniqueNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Student unique number must be in range 10000 - 99999!!!");
                }
            }
        }

        public override string ToString()
        {
            string output = String.Format("Student {0} - Unique Number: {1}",
                this.Name, this.UniqueNumber);

            return output;
        }
    }
}