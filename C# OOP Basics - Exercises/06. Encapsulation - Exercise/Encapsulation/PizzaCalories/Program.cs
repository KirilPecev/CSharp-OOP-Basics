using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] input = Console.ReadLine().Split();
                Pizza pizza = new Pizza(input[1]);

                input = Console.ReadLine().Split();
                pizza.AddDough(new Dough(input[1], input[2], double.Parse(input[3])));

                input = Console.ReadLine().Split();
                while (input[0] != "END")
                {
                    pizza.AddTopping(new Topping(input[1], double.Parse(input[2])));
                    input = Console.ReadLine().Split();
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
