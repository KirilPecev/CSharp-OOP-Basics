using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string name)
        {
            switch (name)
            {
                case nameof(ArmorRepairKit):
                    return new ArmorRepairKit();
                case nameof(HealthPotion):
                    return new HealthPotion();
                case nameof(PoisonPotion):
                    return new PoisonPotion();
                default:
                    throw new ArgumentException($"Invalid item \"{name}\"!");
            }
        }
    }
}
