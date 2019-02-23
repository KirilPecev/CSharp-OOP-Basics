using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> product = new List<Product>();

            string input = Console.ReadLine();
            GetPeople(persons, input);

            input = Console.ReadLine();
            GetProducts(product, input);

            input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputArgs = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                Person currentPerson = persons.Where(x => x.Name == inputArgs[0]).FirstOrDefault();
                Product currentProduct = product.Where(x => x.Name == inputArgs[1]).FirstOrDefault();

                if (currentPerson.Money >= currentProduct.Cost)
                {
                    currentPerson.SubstractMoney(currentProduct.Cost);
                    currentPerson.AddProduct(currentProduct);

                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }

                input = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                if (person.Bag.Count != 0)
                {

                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(x => x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }

            }
        }

        private static void GetProducts(List<Product> list, string input)
        {
            string[] products = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var product in products)
            {
                string name = product.Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
                decimal cost = decimal.Parse(product.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);

                try
                {
                    list.Add(new Product(name, cost));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

            }
        }

        private static void GetPeople(List<Person> list, string input)
        {
            string[] people = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var person in people)
            {
                string name = person.Split("=")[0];
                decimal money = decimal.Parse(person.Split("=")[1]);

                try
                {
                    list.Add(new Person(name, money));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
