/*
 * Exercises:
 * 
 * 1) Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics
      (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes
      (class GSM holding instances of the classes Battery and Display).
 * 2) Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
      Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
 * 3) Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
 * 4) Add a method in the GSM class for displaying all information about it. Try to override ToString().
 * 5) Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
      Ensure all fields hold correct data at any given time.
 * 6) Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
 * 7) Write a class GSMTest to test the GSM class:
        - Create an array of few instances of the GSM class.
        - Display the information about the GSMs in the array.
        - Display the information about the static property IPhone4S.
 * 8) Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
 * 9) Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
 * 10) Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
 * 11) Add a method that calculates the total price of the calls in the call history.
       Assume the price per minute is fixed and is provided as a parameter.
 * 12) Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        - Create an instance of the GSM class.
        - Add few calls.
        - Display the information about the calls.
        - Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        - Remove the longest call from the history and calculate the total price again.
        - Finally clear the call history and print it.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace GSMProgram
{
    public class GSM// Task 1
    {
        private string model;// Task 1
        private string manufacturer;// Task 1
        private decimal? price;// Task 1
        private string owner;// Task 1
        private List<Call> callHistory = new List<Call>();// Task 9
        public decimal pricePerMinute;// Task 10

        public Battery battery = new Battery();
        public Display display = new Display();

        static public Display iPhone4SDisplay = new Display(3.5m);// Task 6
        static public GSM iPhone4S = new GSM("iPhone4S", "Apple", 800m, null, null, iPhone4SDisplay);// Task 6

        public GSM()// Task 2
        {
        }
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Display display)
            : this(model, manufacturer, price, owner, null, display)
        {
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model// Task 5
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("The Model must be more than 1 characters!");
                }
            }
        }

        public string Manufacturer// Task 5
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("The Manufacturer must be more than 1 characters!");
                }
            }
        }

        public decimal? Price// Task 5
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The Price must be positive number!");
                }
            }
        }

        public string Owner// Task 5
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null || value.Length > 1)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("The Owner must be more than 1 characters!");
                }
            }
        }

        public static GSM IPhone4S// Task 6
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public override string ToString()// Task 4
        {
            StringBuilder print = new StringBuilder();

            print.Append("Model: ");
            print.AppendLine(this.Model);
            print.Append("Manufacturer: ");
            print.AppendLine(this.Manufacturer);
            print.Append("Price: ");
            if (this.Price == null)
            {
                print.AppendLine("No Information");
            }
            else
            {
                print.AppendLine(string.Format("{0:C}", this.Price));
            }
            print.Append("Owner: ");
            if (this.Owner == null)
            {
                print.AppendLine("No Information");
            }
            else
            {
                print.AppendLine(this.Owner);
            }
            print.Append("Display: ");
            if (this.display == null)
            {
                print.Append("No Information");
            }
            else
            {
                print.Append("DiagonalSize - ");
                if (this.display.DiagonalSize == null)
                {
                    print.Append(" NoInfo");
                }
                else
                {
                    print.Append(this.display.DiagonalSize);
                    print.Append(" inches");
                }
                print.Append(", NumberOfColors - ");
                if (this.display.NumberOfColors == null)
                {
                    print.Append(" NoInfo");
                }
                else
                {
                    print.Append(this.display.NumberOfColors);
                }
            }
            print.AppendLine();
            print.Append("Battery: ");
            if (this.battery == null)
            {
                print.Append("No information");
            }
            else
            {
                print.Append("Type - ");
                if (this.battery.BatteryType == null)
                {
                    print.Append(" NoInfo");
                }
                else
                {
                    print.Append(this.battery.BatteryType);
                }
                print.Append(", Model - ");
                if (this.battery.Model == null)
                {
                    print.Append(" NoInfo");
                }
                else
                {
                    print.Append(this.battery.Model);
                }
                print.Append(", IdleTime (h) - ");
                if (this.battery.HoursIdle == null)
                {
                    print.Append(" NoInfo");
                }
                else
                {
                    print.Append(this.battery.HoursIdle);
                }
                print.Append(", TalkTime (h) - ");
                if (this.battery.HoursTalk == null)
                {
                    print.Append(" NoInfo");
                }
                else
                {
                    print.Append(this.battery.HoursTalk);
                }
            }
            print.AppendLine();
            return print.ToString();
        }

        public void AddCall(Call call)// Task 10
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(int position)// Task 10
        {
            if (position > -1 && position < this.callHistory.Count)
            {
                this.callHistory.RemoveAt(position);
            }
            else
            {
                throw new ArgumentException("The position is out of range!");
            }
        }

        public void DeleteAllHistory()// Task 10
        {
            this.callHistory.Clear();
        }

        public decimal TotalCallPrice(decimal pricePerMinute)// Task 11
        {
            int totalDuration = 0;
            foreach (Call call in this.callHistory)
            {
                totalDuration += call.CallDuration;
            }

            return (totalDuration / 60) * pricePerMinute;
        }

        public void CallHistoryPrint()
        {
            if (this.callHistory.Count == 0)
            {
                Console.WriteLine("Call History is Empty");
            }
            else
            {
                foreach (Call call in this.callHistory)
                {
                    Console.WriteLine(call);
                }
            }
        }

        static void Main()
        {
        }
    }
}