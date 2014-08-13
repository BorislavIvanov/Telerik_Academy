using System;
using System.Text;

namespace GSMProgram
{
    public class Call// Task 8
    {
        private DateTime callDateAndTime;
        private string dialedPhoneNum;
        private int callDuration;

        public Call(DateTime callDateAndTime, string dialedPhoneNum, int callDuration)
        {
            this.CallDateAndTime = callDateAndTime;
            this.DialedPhoneNum = dialedPhoneNum;
            this.CallDuration = callDuration;
        }

        public DateTime CallDateAndTime
        {
            get
            {
                return this.callDateAndTime;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    this.callDateAndTime = value;
                }
                else
                {
                    throw new ArgumentException("The call Date and Time can't be in future!");
                }
            }
        }

        public string DialedPhoneNum
        {
            get
            {
                return this.dialedPhoneNum;
            }
            set
            {
                if (value.Length > 5 || value.Length < 10)
                {
                    this.dialedPhoneNum = value;
                }
                else
                {
                    throw new ArgumentException("DialedPhoneNum must be more than 5 digits and less than 10 digits!");
                }
            }
        }

        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value > 0)
                {
                    this.callDuration = value;
                }
                else
                {
                    throw new ArgumentException("Call duration must be positive value!");
                }
            }
        }
        
        public override string ToString()
        {
            StringBuilder callPrint = new StringBuilder();
            callPrint.Append("DateTime: ");
            callPrint.Append(this.CallDateAndTime);
            callPrint.Append(", PhoneNumber: ");
            callPrint.Append(this.DialedPhoneNum);
            callPrint.Append(", Duration(sec): ");
            callPrint.Append(this.CallDuration);

            return callPrint.ToString();
        }
    }
}
