using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Factories;
using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class DungeonMaster
    {
        private List<Character> party;
        private Stack<Item> itemPool;
        private int rounds;
        private CharacterFactory characterFactory;
        private ItemFactory itemFactory;

        public DungeonMaster()
        {
            this.party = new List<Character>();
            this.itemPool = new Stack<Item>();
            this.characterFactory = new CharacterFactory();
            this.itemFactory = new ItemFactory();
        }

        public string JoinParty(string[] args)
        {
            Character character = characterFactory.CreateCharacter(args[0],args[1],args[2]);
            this.party.Add(character);

            return $"{character.Name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            Item item = itemFactory.CreateItem(args[0]);
            this.itemPool.Push(item);

            return $"{item.GetType().Name} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Character character = FindCharacter(characterName);

            if (this.itemPool.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            Item item = this.itemPool.Pop();
            character.Bag.AddItem(item);

            return $"{character.Name} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            Character character = FindCharacter(characterName);

            Item item = character.Bag.GetItem(itemName);

            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giverCharacter = FindCharacter(giverName);
            Character receiverCharacter = FindCharacter(receiverName);

            Item item = giverCharacter.Bag.GetItem(itemName);

            giverCharacter.UseItemOn(item, receiverCharacter);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giverCharacter = FindCharacter(giverName);
            Character receiverCharacter = FindCharacter(receiverName);

            Item item = giverCharacter.Bag.GetItem(itemName);

            giverCharacter.GiveCharacterItem(item, receiverCharacter);

            return $"{giverName} gave {receiverName} {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder builder = new StringBuilder();

            this.party.OrderByDescending(c => c.Health > 0).ThenByDescending(c => c.Health).ToList()
                .ForEach(c => builder.AppendLine(c.ToString()));

            return builder.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            string attackerName = args[0];
            string receiverName = args[1];

            Character attacker = FindCharacter(attackerName);
            Character receiver = FindCharacter(receiverName);

            if (attacker is Cleric)
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            ((Warrior)attacker).Attack(receiver);

            builder.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
                builder.AppendLine($"{receiver.Name} is dead!");
            }

            return builder.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            string healerName = args[0];
            string healingReceiverName = args[1];

            Character healer = FindCharacter(healerName);
            Character receiver = FindCharacter(healingReceiverName);

            if (healer is Warrior)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            ((Cleric)healer).Heal(receiver);

            builder.AppendLine($"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!");

            return builder.ToString().TrimEnd();
        }

        public string EndTurn(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            int aliveCharacters = 0;
            foreach (var character in this.party)
            {
                if (character.IsAlive)
                {
                    aliveCharacters++;
                    double healthBeforeRest = character.Health;
                    character.Rest();
                    double currentHealth = character.Health;

                    builder.AppendLine($"{character.Name} rests ({healthBeforeRest} => {currentHealth})");
                }
            }

            if (aliveCharacters == 1 || aliveCharacters == 0)
            {
                this.rounds++;
            }

            return builder.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            return this.rounds > 1;
        }

        private Character FindCharacter(string name)
        {
            Character character = this.party.FirstOrDefault(c => c.Name == name);

            if (character == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }

            return character;
        }
    }
}
