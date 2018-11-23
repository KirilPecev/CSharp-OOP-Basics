using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Enums;
using DungeonsAndCodeWizards.Entities.Items;
using System;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    public abstract class Character
    {
        private const double defaultRestHealMultiplier = 0.2;
        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.IsAlive = true;
            this.RestHealMultiplier = defaultRestHealMultiplier;
            this.Name = name;
            this.BaseHealth = health;
            this.BaseArmor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;

            this.Health = this.BaseHealth;
            this.Armor = this.BaseArmor;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        public double BaseHealth { get; }

        public double Health
        {
            get { return health; }
            private set
            {
                if (value >= this.BaseHealth)
                {
                    health = this.BaseHealth;
                }
                else if (value <= 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        public double BaseArmor { get; }

        public double Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                if (value >= this.BaseArmor)
                {
                    armor = this.BaseArmor;
                }
                else
                {
                    armor = value;
                }
            }
        }

        public double AbilityPoints { get; }

        public Bag Bag { get; private set; }

        public Faction Faction { get; private set; }

        public bool IsAlive { get; private set; }

        public virtual double RestHealMultiplier { get; private set; }

        private string Status => IsAlive ? "Alive" : "Dead";

        public void TakeDamage(double hitPoints)
        {
            if (this.IsAlive)
            {
                if (this.Armor - hitPoints <= 0)
                {
                    this.Health -= hitPoints - this.Armor;
                    this.Armor = 0;
                }
                else
                {
                    this.Armor -= hitPoints;
                }
            }

            if (this.Health <= 0)
            {
                this.IsAlive = false;
            }
        }

        public void Rest()
        {
            EnsuranceIsAlive(this);
            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            EnsuranceIsAlive(this);

            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            EnsuranceIsAlive(this);
            EnsuranceIsAlive(character);

            item.AffectCharacter(character);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            EnsuranceIsAlive(this);
            EnsuranceIsAlive(character);

            character.Bag.AddItem(item);
        }

        public void ReceiveItem(Item item)
        {
            EnsuranceIsAlive(this);

            this.Bag.AddItem(item);
        }

        internal bool EnsuranceIsAlive(Character character)
        {
            if (this.IsAlive)
            {
                return true;
            }
            else
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        internal void GetHeal(double heal)
        {
            this.Health += heal;
        }

        internal void RestoreArmor()
        {
            this.Armor = this.BaseArmor;
        }

        internal void ReduceHeal(int potionDmg)
        {
            this.Health -= potionDmg;
            if (this.Health <= 0)
            {
                this.IsAlive = false;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - HP: {this.Health}/{this.BaseHealth}, AP: {this.Armor}/{this.BaseArmor}, Status: {this.Status}";
        }
    }
}
