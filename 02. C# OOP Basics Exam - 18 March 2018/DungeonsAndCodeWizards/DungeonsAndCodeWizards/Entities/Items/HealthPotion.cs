using DungeonsAndCodeWizards.Entities.Characters;
using System;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public class HealthPotion : Item
    {
        private const int weight = 5;
        private const int potionDmg = 20;

        public HealthPotion() : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            character.EnsuranceIsAlive(character);
            character.GetHeal(potionDmg);
        }
    }
}
