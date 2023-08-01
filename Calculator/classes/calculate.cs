using Calculator.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.classes
{
    internal class calculate: Data_info, IMethod,IShowe1 
    {
        public calculate(double _first_number, double _second_number, int _action) : base(_first_number, _second_number, _action)
        {
        }


        public double Addition()
        {
            return first_number + second_number;
        }

        public double Divide()
        {
            return first_number / second_number;
        }

        public double Multiplication()
        {
            return first_number * second_number;
        }

        public double Subtraction()
        {
            return first_number - second_number;
        }
        public void Info()
        {
            Console.WriteLine("Result: ");
        }
    }
}
