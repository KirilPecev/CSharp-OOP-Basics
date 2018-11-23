using DungeonsAndCodeWizards.Entities.Characters;
using System;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public class PoisonPotion : Item
    {
        private const int weight = 5;
        private const int potionDmg = 20;

        public PoisonPotion() : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            character.EnsuranceIsAlive(character);
            character.ReduceHeal(potionDmg);
        }
    }
}
