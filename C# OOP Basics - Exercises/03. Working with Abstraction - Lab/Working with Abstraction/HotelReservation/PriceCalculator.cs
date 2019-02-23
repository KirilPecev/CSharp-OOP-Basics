using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    static class PriceCalculator
    {
        public static double Calculate(double price, int days, Season season, Discount discount)
        {
            double totalPrice = days * price * (int)season;
            double discountPrice = ((double)discount / 100);

            return totalPrice - (totalPrice*discountPrice);
        }
    }
}
