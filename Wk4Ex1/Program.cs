using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare
            double userMoney = 0;
            int fromCurrency = 0, toCurrency = 0;

            //prompt
            Console.WriteLine("How much Money do you have?");
            //user input for money conversion
            userMoney = Convert.ToDouble(Console.ReadLine());


            //prompt
            Console.WriteLine("What do you want to convert it to? 1 for USD, 2 for EUR, 3 for JPY.");
            //user input for switch case
            toCurrency = Convert.ToInt32(Console.ReadLine());

            //prompt 
            Console.WriteLine("What do you want to convert it from? 1 for USD, 2 for EUR, 3 for JPY.");
            //user input for method call
            fromCurrency = Convert.ToInt32(Console.ReadLine());

            
            //if statement to see if converting to same currency was selected
            if (fromCurrency == toCurrency)
            {
                Console.WriteLine("Already that currency.");
            }

            //for when it isnt the same currency

            else
            {
                //using toCurrency to see what method to call
                switch (toCurrency)
                {
                    case 1:
                        //calling to convert to USD
                        ConvertToUSD(userMoney, fromCurrency);

                        break;
                    case 2:
                        //calling to convert to EUR
                        ConvertToEUR(userMoney, fromCurrency);
                        break;
                    case 3:
                        //calling to convert to JPY
                        ConvertToJPY(userMoney, fromCurrency);
                        break;
                    default:
                        //When a choice wasnt selected correctly
                        Console.WriteLine("Not a choice");
                        break;
                }
            }


        }



        //Converting to USD 
        public static double ConvertToUSD(double userMoney, int fromCurrency)
        {
            //declare money conversion variable
            double conversion = 0;

            //switch case to see what currency to convert from
            switch (fromCurrency)
            {
                //converting from EUR to USD
                case 2://eur
                    //calculation
                    conversion = userMoney * 0.96;
                    //displaying result
                    Console.WriteLine($"Converted {userMoney} EUR to {conversion} USD");
                    break;

                //converting from JPY to USD
                case 3://jpy
                    //calculation
                    conversion = userMoney / 152.20;
                    //displaying result
                    Console.WriteLine($"Converted {userMoney} JPY to {conversion} USD");
                    break;
            }
            return conversion;
        }



        //Convertunf to EUR
        public static double ConvertToEUR(double userMoney, int fromCurrency)
        {
            double conversion = 0;
            switch (fromCurrency)
            {   //converting from USD to EUR
                case 1://usd
                    //calculation
                    conversion = userMoney * 1.04;
                    //displaying result
                    Console.WriteLine($"Converted {userMoney} USD to {conversion} EUR"); 

                    break;
                //converting from JPY to EUR
                case 3://jpy
                    //calculation
                    conversion = userMoney / 158.18;
                    //displaying result
                    Console.WriteLine($"Converted {userMoney} JPY to {conversion} EUR"); 
                    break;
            }
            return conversion;

        }



        //Converting to JPY
        public static double ConvertToJPY(double userMoney, int fromCurrency)
        {
            double conversion = 0;
            switch (fromCurrency)
            {
                //converting from USD to JPY
                case 1://usd

                    //calculation
                    conversion = userMoney * 152.20;
                    //displaying result
                    Console.WriteLine($"Converted {userMoney} USD to {conversion} JPY"); 

                    break;

                //converting from EUR to JPY
                case 2://eur


                    //calculation
                    conversion = userMoney * 158.18;
                    //displaying result
                    Console.WriteLine($"Converted {userMoney} EUR to {conversion} JPY");

                    break;

            }
            return conversion;
        }


    }
}
