using System;

namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                string[] args = Console.ReadLine().Split();
                switch (args[0])
                {
                    case "Create":
                        studentSystem.Create(args);
                        break;
                    case "Show":
                        studentSystem.Show(args);
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
