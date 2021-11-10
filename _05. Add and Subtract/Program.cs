using System;

namespace _05._Add_and_Subtract {
    class Program {
        static void Main(string[] args) {
            // You will receive 3 integers.
            // Create a method that returns the sum of the first
            // two integers and another method that subtracts the
            // third integer from the result of the sum method.

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sub(Sum(num1, num2), num3));
        }

        private static int Sum(int num1, int num2) {
            return num1 + num2;
        }

        private static int Sub(int num1, int num2) {
            return num1 - num2;
        }
    }
}