using System;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = "Pesho";
            int age = 18;
            Person p = new Person(name,age);
            Console.WriteLine(p.GetBalance());
        }
    }
}
