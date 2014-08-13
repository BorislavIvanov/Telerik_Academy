using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines
{
    class Pilot : IPilot
    {
        private string name;
        private List<IMachine> listOfMachines;

        public Pilot(string name)
        {
            this.Name = name;
            this.listOfMachines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Pilot Name!!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddMachine(IMachine machine)
        {
            listOfMachines.Add(machine);
            listOfMachines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.AppendFormat("{0} - ", this.Name);
            if (this.listOfMachines.Count > 0)
            {
                report.AppendFormat("{0} {1}", this.listOfMachines.Count, this.listOfMachines.Count == 1 ? "machine" : "machines");

                foreach (var machine in this.listOfMachines)
                {
                    report.AppendLine();
                    report.Append(machine);
                }
            }
            else
            {
                report.Append("no machines");
            }

            return report.ToString();
        }
    }
}
