using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Fighter : IFighter
    {
        private bool stealthMode;
        private string name;
        private IPilot pilot = null;
        private double healthPoints = 200;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.StealthMode = stealthMode;
            this.targets = new List<string>();
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
            private set { this.stealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            if (StealthMode)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
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
                    throw new ArgumentException("Invalid Fighter Name!!!");
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
                return this.attackPoints;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Fighter AttackPoints can't be 0!!!");
                }
                else if (value > double.MaxValue)
                {
                    throw new ArgumentException("The Fighter AttackPoints can't be more than \"double\" range!!!");
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
                return this.defensePoints;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Fighter DefensePoints can't be 0!!!");
                }
                else if (value > double.MaxValue)
                {
                    throw new ArgumentException("The Fighter DefensePoints can't be more than \"double\" range!!!");
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
            output.AppendFormat(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF");

            return output.ToString();
        }
    }
}
