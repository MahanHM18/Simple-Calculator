using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Math : IMath
    {
        private double _number1, _number2, _result;

        public void Division(double num1, double num2)
        {
            _number1 = num1;
            _number2 = num2;
            _result = num1 / num2;
        }

        public void Minus(double num1, double num2)
        {
            _number1 = num1;
            _number2 = num2;
            _result = num1 - num2;
        }

        public void Multiple(double num1, double num2)
        {
            _number1 = num1;
            _number2 = num2;
            _result = num1 * num2;
        }

        public double Result()
        {
            return _result;
        }

        public void Sum(double num1, double num2)
        {
            _number1 = num1;
            _number2 = num2;
            _result = num1 + num2;
        }
    }
}
