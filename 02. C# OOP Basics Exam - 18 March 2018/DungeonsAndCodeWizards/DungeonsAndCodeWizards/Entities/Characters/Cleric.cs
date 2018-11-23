using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Enums;
using DungeonsAndCodeWizards.Entities.Interfaces;
using System;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    public class Cleric : Character, IHealable
    {
        private const double baseHealth = 50;
        private const double baseArmor = 25;
        private const double abilityPoints = 40;

        public Cleric(string name, Faction faction)
            : base(name, baseHealth, baseArmor, abilityPoints, bag: new Backpack(), faction: faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                if (this.Faction != character.Faction)
                {
                    throw new InvalidOperationException("Cannot heal enemy character!");
                }

                character.GetHeal(this.AbilityPoints);
            }
            else
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
