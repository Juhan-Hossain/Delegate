using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class Calculation
    {

        public delegate double JuhansCalculator(double firstNum, double lastNum);
        public static double Add(double firstNum, double lastNum)
        {
            return (firstNum + lastNum);
        }

        public static double Substract(double firstNum, double lastNum)
        {
            return firstNum - lastNum;
        }

        public static double Multiply(double firstNum, double lastNum)
        {
            return firstNum * lastNum;
        }

        public static double Devide(double firstNum, double lastNum)
        {
            return firstNum / lastNum;
        }

        public static double Modulo(double firstNum, double lastNum)
        {
            return firstNum % lastNum;
        }
    }
}
