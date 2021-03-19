using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Equation equ = new Equation();
            List<Equation> calc = new List<Equation>();
            List<string> list = new List<string>();
            string input = "";
            string input2 = "";

            do
            {
                Console.WriteLine("Do you have any equation input? Please enter Yes/Y or No/N>>");
                input = Console.ReadLine().ToLower();

                Console.WriteLine("Please enter your left value");
                equ.Left = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your right value");
                equ.Right = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please state one of these options: multiply, add, subtract, left, right. Left = left to the power. Right = right to the power");
                input2 = Console.ReadLine().ToLower();

                if (input2 == "multiply")
                {
                    foreach (Equation e in calc)
                    {
                        Console.WriteLine($"{e.Multiply()}");
                        string m = Console.ReadLine();
                        list.Add(m);

                    }
                }
                else if (input2 == "add")
                {
                    foreach (Equation e in calc)
                    {
                        Console.WriteLine($"{e.Add()}");
                        string a = Console.ReadLine();
                        list.Add(a);
                    }
                }
                else if (input2 == "subtract")
                {
                    foreach (Equation e in calc)
                    {
                        Console.WriteLine($"{e.Subtract()}");
                        string s = Console.ReadLine();
                        list.Add(s);
                    }
                }
                else if (input2 == "left")
                {
                    foreach (Equation e in calc)
                    {
                        Console.WriteLine(e.LeftToThePower(power: (int)e.Right));
                        string l = Console.ReadLine();
                        list.Add(l);
                    }
                }
                else if (input2 == "right")
                {
                    foreach (Equation e in calc)
                    {
                        Console.WriteLine(e.RightToThePower(power: (int)e.Left));
                        string r = Console.ReadLine();
                        list.Add(r);
                    }
                }


            } while (input == "yes");

            list.ForEach(Console.WriteLine);


            Console.ReadKey();
        }

    }
}
