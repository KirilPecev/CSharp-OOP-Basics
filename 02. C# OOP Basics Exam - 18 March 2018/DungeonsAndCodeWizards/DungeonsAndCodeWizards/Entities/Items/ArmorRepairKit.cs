using DungeonsAndCodeWizards.Entities.Characters;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public class ArmorRepairKit : Item
    {
        private const int weight = 10;

        public ArmorRepairKit() : base(weight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            character.EnsuranceIsAlive(character);
            character.RestoreArmor();
        }
    }
}
