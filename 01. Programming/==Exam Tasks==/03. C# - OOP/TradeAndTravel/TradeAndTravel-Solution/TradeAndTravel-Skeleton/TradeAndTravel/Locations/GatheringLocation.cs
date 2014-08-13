using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class GatheringLocation : Location, IGatheringLocation
    {
        public ItemType GatheredType { get; private set; }

        public ItemType RequiredItem { get; private set; }

        public GatheringLocation(string name, LocationType type, ItemType gatheredType, ItemType requiredItem)
            : base(name, type)
        {
            this.GatheredType = gatheredType;
            this.RequiredItem = requiredItem;
        }

        public Item ProduceItem(string name)
        {
            if (GatheredType == ItemType.Wood)
            {
                return new Wood(name);
            }
            else if (GatheredType == ItemType.Iron)
            {
                return new Iron(name);
            }
            else
            {
                return null;
            }
        }
    }
}
