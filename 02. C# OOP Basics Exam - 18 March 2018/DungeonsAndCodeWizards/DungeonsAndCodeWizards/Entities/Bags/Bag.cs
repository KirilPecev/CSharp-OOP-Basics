using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonsAndCodeWizards.Entities.Bags
{
    public abstract class Bag
    {
        private const int defaultBagCapacity = 100;
        private readonly List<Item> items;

        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity { get; } = defaultBagCapacity;

        public int Load => this.Items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (!this.Items.Any())
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            Item item = this.Items.FirstOrDefault(i => i.GetType().Name == name);
            if (item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            this.items.Remove(item);

            return item;
        }
    }
}
