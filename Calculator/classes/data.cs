using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.classes
{
    internal abstract class Data_info
    {
        public double first_number = 0;
        public double second_number = 0;

        public int action =0;

        public Data_info(double _first_number, double _second_number, int _action)
        {
            first_number = _first_number;
            second_number = _second_number;
            action = _action;
        }
        Data_info()
        {

        }
        ~Data_info() { }
    }
}
