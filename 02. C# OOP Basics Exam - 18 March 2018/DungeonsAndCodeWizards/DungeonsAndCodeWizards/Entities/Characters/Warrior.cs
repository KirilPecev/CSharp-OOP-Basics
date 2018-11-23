using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Enums;
using DungeonsAndCodeWizards.Entities.Interfaces;
using System;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    public class Warrior : Character, IAttackable
    {
        private const double baseHealth = 100;
        private const double baseArmor = 50;
        private const double abilityPoints = 40;

        public Warrior(string name, Faction faction)
            : base(name, baseHealth, baseArmor, abilityPoints, bag: new Satchel(), faction: faction)
        {

        }

        public void Attack(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                if (this == character)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }
                else if (this.Faction == character.Faction)
                {
                    throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
                }

                character.TakeDamage(this.AbilityPoints);
            }
            else
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
