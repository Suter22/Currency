using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = 0;
            string secondcurrency;
            double exchangerate = 0;
            double converted = 0;
            double fee = 0;
            double total = 0;
            double add;
            

            Console.WriteLine("Currency Convertor");

            while(true)
            {
                Console.Clear();
                Console.Write("How Much GBP Is Being Converted(max = 2500): ");
                pounds = Convert.ToDouble(Console.ReadLine());

                if(pounds <= 300)
                {
                    fee = 0.035;
                    break;
                }
                if (pounds > 300 && pounds <= 750)
                {
                    fee = 0.03;
                    break;
                }
                if (pounds > 750 && pounds <= 1000)
                {
                    fee = 0.025;
                    break;
                }
                if (pounds > 1000 && pounds <= 2000)
                {
                    fee = 0.02;
                    break;
                }
                if (pounds > 2000 && pounds <= 2500)
                {
                    fee = 0.015;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            while (true)
            {
                Console.Clear();
                Console.Write("Enter Currency to Convert to (USD, EUR, BRL, JPY, TRY): ");
                secondcurrency = Console.ReadLine();
                secondcurrency.ToUpper();

                if(secondcurrency == "USD")
                {
                    exchangerate = 1.4;
                    break;
                }
                if (secondcurrency == "EUR")
                {
                    exchangerate = 1.14;
                    break;
                }
                if (secondcurrency == "BRL")
                {
                    exchangerate = 4.77;
                    break;
                }
                if (secondcurrency == "JPY")
                {
                    exchangerate = 151.05;
                    break;
                }
                if (secondcurrency == "TRY")
                {
                    exchangerate = 5.68;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            converted = pounds * exchangerate;
            add = pounds * fee;
            total = pounds + add;
            
            while(true)
            {
                Console.Clear();
                Console.Write("Is The Customer A Member of Staff (Y,N): ");
                string yn = Console.ReadLine();
                yn.ToUpper();

                if(yn == "Y")
                {
                    double discount = total * 0.005;
                    double total2 = total - discount;
                    total2 = Math.Round(total2,2);
                    add = Math.Round(add, 2);
                    total = Math.Round(total, 2);
                    Console.WriteLine(converted + " " + secondcurrency);
                    Console.WriteLine("Transaction Fee = £" + add);
                    Console.WriteLine("£" + total);
                    Console.WriteLine("Discount Price = £" + total2);
                    break;
                }
                if(yn == "N")
                {
                    add = Math.Round(add, 2);
                    total = Math.Round(total, 2);
                    Console.WriteLine(converted + " " + secondcurrency);
                    Console.WriteLine("Transaction Fee = £" + add);
                    Console.WriteLine("£" + total + " No Discount");
                    break;
                }
                else
                {
                    Console.WriteLine("Inavlid Input");
                }
            }
            Console.ReadKey();
        }
    }
}
