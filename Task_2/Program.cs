using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            // double tax = 0.075;
            //double subtotal = 0;
            double shotqty = 0;
            string shot = "";
            string input;

            Dictionary<string, double> items = new Dictionary<string, double>();

            items.Add("espresso", 2.15);
            items.Add("cappuccino", 4.20);
            items.Add("latte", 5.00);
            items.Add("americano", 3.55);
            items.Add("drip", 1.25);

            Dictionary<string, double> extras = new Dictionary<string, double>();
            items.Add("shot of vanilla", 0.75);
            items.Add("shot of espresso", 0.80);

            //wait for hello then out menu
            string r = Console.ReadLine().ToLower().Trim();
            if (r == "hello")
            {
                foreach (KeyValuePair<string, double> menu in items)
                {
                    Console.WriteLine("Greetings! :) I hope you are having a great day! See below for menu items and prices.");
                    Console.WriteLine($"\t{menu.Key} : {menu.Value:C2}");
                }
            }
            do
            {
                Console.WriteLine("Which drink do you want to order?");
                input = Console.ReadLine().ToLower(); //*****

                foreach (KeyValuePair<string, double> menu in extras)
                {
                    Console.WriteLine("See below for shot options!");
                    Console.WriteLine($"\t{menu.Key} : {menu.Value:C2}");
                }
                string input2;
                Console.WriteLine("Do you want to order a shot? Say yes or no.");
                input2 = Console.ReadLine().ToLower().Trim();

                if (input2 == "yes")
                {
                    Console.WriteLine("Which shot? Say espresso or vanilla.");
                    shot = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine("Quantity of shots? Say 1, 2, 3+");
                    shotqty = Convert.ToDouble(Console.ReadLine());
                    extras.Add(shot, shotqty); //****
                }
                Console.WriteLine("Do you want another drink? Yes or no");
                answer = Console.ReadLine().Trim().ToLower();
            } while (answer == "yes");

            //output each line item (either price or the order based upon how far 
            //you want to go) and then the total for the order, make sure to include
            //a sales tax of 7.5% on the total order.

            foreach (var pair in items)
            {
                foreach (var group in extras)
                {
                    if (items.ContainsKey(input) && extras.ContainsKey(shot))
                    {
                        Console.WriteLine($"Order item: {input} Cost: ${0} in addition to a Sales Tax of 7.5%", pair.Value);
                    }
                }
            }


        }
    }
}