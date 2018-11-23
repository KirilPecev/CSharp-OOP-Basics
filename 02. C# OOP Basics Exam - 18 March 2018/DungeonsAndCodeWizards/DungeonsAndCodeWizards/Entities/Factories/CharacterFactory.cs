using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Enums;
using System;

namespace DungeonsAndCodeWizards.Entities.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string type, string name)
        {
            if (!Enum.TryParse<Faction>(faction, out var parsedFaction))
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }

            switch (type)
            {
                case nameof(Warrior):
                    return new Warrior(name, parsedFaction);
                case nameof(Cleric):
                    return new Cleric(name, parsedFaction);
                default:
                    throw new ArgumentException($"Invalid character type \"{type}\"!");
            }
        }
    }
}
