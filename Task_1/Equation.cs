using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation()
        {
            Left = 0;
            Right = 0;
        }
        public Equation(double left, double right)
        {
            right = Right;
            left = Left;
        }
        public double Add()
        {
            double add = Left + Right;
            return add;
        }
        public double Subtract()
        {
            double subtract = Left - Right;
            return subtract;
        }
        public double Multiply()
        {
            double multiply = Left * Right;
            return multiply;
        }
        public double LeftToThePower(int power)
        {
            power = (int)Right;
            double leftpower = Math.Pow(Left, power);
            return leftpower;
        }
        //CHECK, THIS WRONG OR RIGHT WHEN I RUN CODE
        public double RightToThePower(int power)
        {
            power = (int)Left;
            double rightpower = Math.Pow(Right, power);
            return rightpower;
        }

    }
}
