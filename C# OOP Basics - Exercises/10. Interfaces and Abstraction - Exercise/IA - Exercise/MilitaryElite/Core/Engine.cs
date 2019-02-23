using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    class Engine
    {
        public void Run()
        {
            List<Soldier> soldiers = new List<Soldier>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();
                string type = inputArgs[0];

                switch (type)
                {
                    case nameof(Private):
                        AddPrivate(soldiers, inputArgs);
                        break;
                    case nameof(LieutenantGeneral):
                        AddLieutenantGeneral(soldiers, inputArgs);
                        break;
                    case nameof(Engineer):
                        AddEngineer(soldiers, inputArgs);
                        break;
                    case nameof(Commando):
                        AddCommando(soldiers, inputArgs);
                        break;
                    case nameof(Spy):
                        AddSpy(soldiers, inputArgs);
                        break;
                }

                input = Console.ReadLine();
            }

            soldiers.ForEach(Console.WriteLine);
        }

        private void AddSpy(List<Soldier> soldiers, string[] inputArgs)
        {
            Spy spy = new Spy(inputArgs[1], inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]));

            soldiers.Add(spy);
        }

        private void AddCommando(List<Soldier> soldiers, string[] inputArgs)
        {
            try
            {
                Commando commando = new Commando(inputArgs[1], inputArgs[2], inputArgs[3], decimal.Parse(inputArgs[4]), inputArgs[5]);

                for (int i = 6; i < inputArgs.Length; i += 2)
                {
                    try
                    {
                        Mission mission = new Mission(inputArgs[i], inputArgs[i + 1]);
                        commando.AddMission(mission);
                    }
                    catch (ArgumentException)
                    {

                    }
                }

                soldiers.Add(commando);
            }
            catch (ArgumentException)
            {

            }
        }

        private void AddEngineer(List<Soldier> soldiers, string[] inputArgs)
        {
            try
            {
                Engineer engineer = new Engineer(inputArgs[1], inputArgs[2], inputArgs[3], decimal.Parse(inputArgs[4]), inputArgs[5]);

                for (int i = 6; i < inputArgs.Length; i += 2)
                {
                    Repair repair = new Repair(inputArgs[i], int.Parse(inputArgs[i + 1]));
                    engineer.AddRepair(repair);
                }

                soldiers.Add(engineer);
            }
            catch (ArgumentException)
            {

            }
        }

        private void AddLieutenantGeneral(List<Soldier> soldiers, string[] inputArgs)
        {
            LieutenantGeneral general = new LieutenantGeneral(inputArgs[1], inputArgs[2], inputArgs[3], decimal.Parse(inputArgs[4]));

            for (int i = 5; i < inputArgs.Length; i++)
            {
                Private privat = (Private)soldiers.Single(s => s.Id == inputArgs[i]);
                general.AddPrivate(privat);
            }

            soldiers.Add(general);
        }

        private void AddPrivate(List<Soldier> soldiers, string[] inputArgs)
        {
            Private @private = new Private(inputArgs[1], inputArgs[2], inputArgs[3], decimal.Parse(inputArgs[4]));

            soldiers.Add(@private);
        }
    }
}
