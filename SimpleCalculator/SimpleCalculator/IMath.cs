using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public interface IMath
    {
        void Sum(double num1, double num2);
        void Minus(double num1, double num2);
        void Multiple(double num1, double num2);
        void Division(double num1, double num2);
        double Result();
    }
}
