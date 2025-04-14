using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userMoney = 0;
            int fromCurrency, toCurrency;
            Console.Write("How much Money do you have?");
            userMoney = Convert.ToDouble(Console.Read());

            Console.Write("What type of money is it? 1 For USD 2 for EUR and 3 For JPY");
            fromCurrency = Convert.ToInt32(Console.Read());

            Console.WriteLine($"You have {userMoney}, selected {fromCurrency}");

            Console.Write("What do you want to convert it to?");
            toCurrency = Convert.ToInt32(Console.Read());

            switch (toCurrency)
            {
                case 1:
                    ConvertToUSD(userMoney, fromCurrency);
                    break;
                case 2:

                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Not a choice");
                    break;
            }


        }

        public static double ConvertToUSD(double userMoney, int fromCurrency)
        {
            switch (fromCurrency)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
            return Convert.ToDouble(Console.Read());
        }


    }
}
