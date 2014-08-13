using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : ITank
    {
        private bool defenseMode = true;
        private string name;
        private IPilot pilot = null;
        private double healthPoints = 100;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Tank(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }
        }

        public void ToggleDefenseMode()
        {
            if (DefenseMode)
            {
                defenseMode = false;
            }
            else
            {
                defenseMode = true;
            }
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
                    throw new ArgumentException("Invalid Tank Name!!!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get
            {
                if (DefenseMode)
                {
                    return this.attackPoints - 40;
                }
                else
                {
                    return this.attackPoints;
                }
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Tank AttackPoints can't be 0!!!");
                }
                else if (value > double.MaxValue)
                {
                    throw new ArgumentException("The Tank AttackPoints can't be more than \"double\" range!!!");
                }
                else
                {
                    this.attackPoints = value;
                }
            }
        }

        public double DefensePoints
        {
            get
            {
                if (DefenseMode)
                {
                    return this.defensePoints + 30;
                }
                else
                {
                    return this.defensePoints;
                }
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Tank DefensePoints can't be 0!!!");
                }
                else if (value > double.MaxValue)
                {
                    throw new ArgumentException("The Tank DefensePoints can't be more than \"double\" range!!!");
                }
                else
                {
                    this.defensePoints = value;
                }
            }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("- " + this.Name);
            output.AppendLine(" *Type: " + this.GetType().Name);
            output.AppendLine(" *Health: " + this.HealthPoints);
            output.AppendLine(" *Attack: " + this.AttackPoints);
            output.AppendLine(" *Defense: " + this.DefensePoints);
            if (this.Targets.Count > 0)
            {
                output.AppendLine(" *Targets: " + string.Join(", ", this.Targets));
            }
            else
            {
                output.AppendLine(" *Targets: None");
            }
            output.AppendFormat(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF");

            return output.ToString();
        }
    }
}
