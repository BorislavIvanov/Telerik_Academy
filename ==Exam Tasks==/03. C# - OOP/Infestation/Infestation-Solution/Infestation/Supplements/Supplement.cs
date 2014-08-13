using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    abstract class Supplement : ISupplement
    {
        private int powerEffect = 0;
        private int healthEffect = 0;
        private int aggressionEffect = 0;

        protected Supplement()
        {
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }

        public int PowerEffect
        {
            get { return this.powerEffect; }
            set { this.powerEffect = value; }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            set { this.healthEffect = value; }
        }

        public int AggressionEffect
        {
            get { return this.aggressionEffect; }
            set { this.aggressionEffect = value; }
        }
    }
}
