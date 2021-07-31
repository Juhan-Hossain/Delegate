using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {


            Calculation.JuhansCalculator add = Calculation.Add;
            Calculation.JuhansCalculator substract = Calculation.Substract;
            Calculation.JuhansCalculator multiply = Calculation.Multiply;
            Calculation.JuhansCalculator devide = Calculation.Devide;
            Calculation.JuhansCalculator modulo = Calculation.Devide;

            //public static double result = 0;

            /*Console.WriteLine("Please Enter two Number to Calculate :");*/
            Console.WriteLine("Please Enter 1st Number to Calculate :");
            double firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter 2nd Number to Calculate :");
            double lastNumber = Convert.ToInt32(Console.ReadLine());
            /*double result = add(firstNumber, lastNumber);
            Console.WriteLine(result);*/
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press 1 to Add:");
            Console.WriteLine("Press 2 to Substract:");
            Console.WriteLine("Press 3 to Multiply:");
            Console.WriteLine("Press 4 to Devide:");
            Console.WriteLine("Press 5 to find Modulo:");
            Console.WriteLine("Press 0/Anything Else to ESC:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Choose an option:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    double result = add(firstNumber, lastNumber);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("The result of addition is: "+result);
                    break;
                case 2:
                    result = substract(firstNumber, lastNumber);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("The result of Substraction is: "+result);
                    break;

                case 3:
                    result = multiply(firstNumber, lastNumber);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("The result of Multiplying is: " + result);
                    break;
                case 4:
                    result = devide(firstNumber, lastNumber);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("The result of Division is: " + result);
                    break;
                case 5:
                    result = modulo(firstNumber, lastNumber);
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("The result of Modulo is: " + result);
                    break;

                default:
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("You Choose a non existing Option!!!");
                    break;


            }
        }
    }
}

