﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        int pointsOfAttack = 0;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
        }
        public int AttackPoints
        {
            get { return pointsOfAttack; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int ninjaTarget = default(int);

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0
                    && availableTargets[i].HitPoints > availableTargets[ninjaTarget].HitPoints)
                {
                    ninjaTarget = i;
                }

                if (i == (availableTargets.Count - 1))
                {
                    return ninjaTarget;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                pointsOfAttack += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                pointsOfAttack += resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}
