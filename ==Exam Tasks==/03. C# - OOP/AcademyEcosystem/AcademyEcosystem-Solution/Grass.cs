﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    class Grass : Plant
    {
        public Grass(Point location)
            : base(location, 2)
        {
            
        }

        public override void Update(int time)
        {
            if (IsAlive)
            {
                this.Size += time;
            }
        }
    }
}
