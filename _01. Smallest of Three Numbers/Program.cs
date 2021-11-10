using System;

namespace _01._Smallest_of_Three_Numbers {
    class Program {
        static void Main(string[] args) {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SmallestNum(num1, num2, num3));
        }

        static int SmallestNum(int num1, int num2, int num3) {
            return Math.Min(Math.Min(num1, num2), num3);
        }
    }
}