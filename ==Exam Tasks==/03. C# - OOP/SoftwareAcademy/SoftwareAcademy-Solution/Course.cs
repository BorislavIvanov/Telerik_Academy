using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private List<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Course Name is Invalid!!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public List<string> Topics
        {
            get
            {
                return this.topics;
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("Name={0}", this.Name);

            if (this.Teacher != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            if (this.Topics.Count > 0)
            {
                output.AppendFormat("; Topics=[{0}]", String.Join(", ", this.Topics));
            }

            return output.ToString();
        }
    }
}
