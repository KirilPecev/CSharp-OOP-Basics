using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int id = int.Parse(commands[1]);

                switch (command)
                {
                    case "Create":
                        Create(accounts, id);
                        break;
                    case "Deposit":
                        Deposit(accounts, id, int.Parse(commands[2]));
                        break;
                    case "Withdraw":
                        Withdraw(accounts, id, int.Parse(commands[2]));
                        break;
                    case "Print":
                        Print(accounts, id);
                        break;
                }


                input = Console.ReadLine();
            }
        }

        private static void Print(Dictionary<int, BankAccount> accounts, int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id]);
            }
        }

        private static void Withdraw(Dictionary<int, BankAccount> accounts, int id, int amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }

        private static void Deposit(Dictionary<int, BankAccount> accounts, int id, int amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);
            }
        }

        private static void Create(Dictionary<int, BankAccount> accounts, int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                accounts.Add(id, new BankAccount { Id = id });
            }
        }
    }
}
