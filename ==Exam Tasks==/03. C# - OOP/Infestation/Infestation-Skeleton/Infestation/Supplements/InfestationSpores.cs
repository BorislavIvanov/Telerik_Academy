using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class InfestationSpores : Supplement
    {
        public InfestationSpores()
            : base()
        {
            this.AggressionEffect = 20;
            this.PowerEffect = -1;
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.AggressionEffect = 0;
                this.PowerEffect = 0;
            }
        }
    }
}
