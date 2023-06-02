using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
/// <summary>
/// Интерфейс для класса Calc
/// </summary>
    internal interface ICalc
    {
        double Sum(double a, double b);
        void ReadUserNumbers(out double a, out double b);
    }

}
