using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class ModifiedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            var craftedItemType = commandWords[2];
            string craftedItemName = commandWords[3];
            Item theNewCraftedItem = null;
            var actorInventory = actor.ListInventory();

            if (craftedItemType == "weapon")
            {
                bool hasWood = PossessTheRequiredItem(actorInventory, ItemType.Wood);
                bool hasIron = PossessTheRequiredItem(actorInventory, ItemType.Iron);

                if (hasWood && hasIron)
                {
                    theNewCraftedItem = new Weapon(craftedItemName);
                    this.AddToPerson(actor, theNewCraftedItem);
                    theNewCraftedItem.UpdateWithInteraction("craft");
                }
            }
            else if (craftedItemType == "armor")
            {
                bool hasIron = PossessTheRequiredItem(actorInventory, ItemType.Iron);

                if (hasIron)
                {
                    theNewCraftedItem = new Armor(craftedItemName);
                    this.AddToPerson(actor, theNewCraftedItem);
                    theNewCraftedItem.UpdateWithInteraction("craft");
                }
            }
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            string newItemName = commandWords[2];
            var actorInventory = actor.ListInventory();
            Item newItem = null;

            if (actor.Location.LocationType == LocationType.Forest)
            {
                bool hasWeapon = PossessTheRequiredItem(actorInventory, ItemType.Weapon);

                if (hasWeapon)
                {
                    newItem = new Wood(newItemName);
                    this.AddToPerson(actor, newItem);
                    newItem.UpdateWithInteraction("gather");
                }
            }
            else if (actor.Location.LocationType == LocationType.Mine)
            {
                bool hasArmor = PossessTheRequiredItem(actorInventory, ItemType.Armor);

                if (hasArmor)
                {
                    newItem = new Iron(newItemName);
                    this.AddToPerson(actor, newItem);
                    newItem.UpdateWithInteraction("gather");
                }
            }
        }

        private bool PossessTheRequiredItem(List<Item> actorInventory, ItemType itemType)
        {
            bool hasTheItem = false;

            foreach (var item in actorInventory)
            {
                if (item.ItemType == itemType)
                {
                    hasTheItem = true;
                    break;
                }
            }

            return hasTheItem;
        }
    }
}
