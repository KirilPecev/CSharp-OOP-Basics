using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double price = double.Parse(input[0]);
            int days = int.Parse(input[1]);
            string season = input[2];
            string discount = "";
            if (input.Length==4)
            {
                discount = input[3];
            }

            Season s = new Season();
            Discount d = Discount.None;

            switch (season)
            {
                case "Autumn":
                    s = Season.Autumn;
                    break;
                case "Spring":
                    s = Season.Spring;
                    break;
                case "Winter":
                    s = Season.Winter;
                    break;
                case "Summer":
                    s = Season.Summer;
                    break;
            }

            switch (discount)
            {
                case "VIP":
                    d = Discount.VIP;
                    break;
                case "SecondVisit":
                    d = Discount.VisitingForSecondTime;
                    break;
            }

            double totalPrice = PriceCalculator.Calculate(price, days,s,d);
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
