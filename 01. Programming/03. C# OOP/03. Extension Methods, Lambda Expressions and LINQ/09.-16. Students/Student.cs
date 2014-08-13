using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09._16.Students
{
    public class Student
    {
        //Fields
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private int groupNumber;
        private Group group;
        private List<int> marks;

        //Constructor
        public Student(string firstName, string lastName, string fn, string tel, string email, int groupNumber, params int[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = new List<int>(marks);
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Invalid First Name!!!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Invalid Second Name!!!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public string FN
        {
            get
            {
                return this.fn;
            }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid FN!!!");
                }
                else
                {
                    this.fn = value;
                }
            }
        }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (value.Length < 9 && value.All(c => (c < '0' && c > '9') || c !='/' ))
                {
                    throw new ArgumentException("Invalid Telephone Number!!!");
                }
                else
                {
                    this.tel = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (IsEmail(value) == false) //Email Validation
                {
                    throw new ArgumentException("Invalid Email!!!");
                }
                else
                {
                    this.email = value;
                }
            }
        }
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
                    throw new ArgumentException("Group number can't be 0 or negative!!!");
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }
        public Group Group { get; set; }
        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                if (value.All(m => m < 1 || m > 6))
                {
                    throw new ArgumentException("Invalid Value in Marks!!!");
                }
                else
                {
                    this.marks = value;
                }
            }
        }
        
        //Methods
        public void AddMark(int mark)
        {
            if (mark < 1 || mark > 6)
            {
                throw new ArgumentException("Invalid Mark!!! Mark must be in range (1-6)!!!");
            }
            else
            {
                this.marks.Add(mark);
            }
        }
        public void RemoveMarksAtPosition(int position)
        {
        }
        private static bool IsEmail(string strEmail) //Email Validator
        {
            Regex rgxEmail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                       @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                       @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return rgxEmail.IsMatch(strEmail);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("FirstName: {0}, LastName: {1}, FN: {2}, Tel: {3}", this.FirstName, this.LastName, this.FN, this.Tel);
            output.AppendLine();
            output.AppendFormat("Email: {0}, GroupNumber: {1}", this.Email, this.GroupNumber);
            output.AppendLine();
            output.AppendFormat("Marks: {0}", string.Join(", ", this.Marks));
            output.AppendLine();

            return output.ToString();
        }
    }
}
