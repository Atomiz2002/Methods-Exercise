using System;

namespace _08._Factorial_Division {
    class Program {
        static void Main(string[] args) {
            double num1 = FactorialInput(Convert.ToDouble(Console.ReadLine()));
            double num2 = FactorialInput(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($"{(num1 / num2):F2}");
        }

        private static double FactorialInput(double num) {
            for (double i = num - 1; i > 0; i--) {
                num *= i;
            }
            return num;
        }
    }
}