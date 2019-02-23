using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        private decimal money;

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        private List<Product> bag;

        public List<Product> Bag
        {
            get { return bag; }
            set { bag = value; }
        }


        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public void AddProduct(Product p)
        {
            this.Bag.Add(p);
        }

        public void SubstractMoney(decimal amount)
        {
            this.Money -= amount;
        }
    }
}
