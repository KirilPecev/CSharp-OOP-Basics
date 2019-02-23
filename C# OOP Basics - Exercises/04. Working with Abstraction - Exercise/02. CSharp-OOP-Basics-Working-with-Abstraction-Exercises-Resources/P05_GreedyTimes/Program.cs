using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long capacityOfTheBag = long.Parse(Console.ReadLine());
            string[] itemsQuantity = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long totalGoldAmount = 0;
            long totalGemAmount = 0;
            long totalCashAmount = 0;

            for (int i = 0; i < itemsQuantity.Length; i += 2)
            {
                string item = itemsQuantity[i];
                long quantity = long.Parse(itemsQuantity[i + 1]);

                string type = string.Empty;

                if (item.Length == 3)
                {
                    type = "Cash";
                }
                else if (item.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (item.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "")
                {
                    continue;
                }
                else if (capacityOfTheBag < bag.Values.Select(x => x.Values.Sum()).Sum() + quantity)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (quantity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + quantity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(type))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (quantity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[type].Values.Sum() + quantity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(type))
                {
                    bag[type] = new Dictionary<string, long>();
                }

                if (!bag[type].ContainsKey(item))
                {
                    bag[type][item] = 0;
                }

                bag[type][item] += quantity;
                if (type == "Gold")
                {
                    totalGoldAmount += quantity;
                }
                else if (type == "Gem")
                {
                    totalGemAmount += quantity;
                }
                else if (type == "Cash")
                {
                    totalCashAmount += quantity;
                }
            }

            foreach (var type in bag)
            {
                Console.WriteLine($"<{type.Key}> ${type.Value.Values.Sum()}");
                foreach (var item in type.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }
    }
}