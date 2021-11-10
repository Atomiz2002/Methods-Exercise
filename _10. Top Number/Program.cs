using System;
using System.Linq;

namespace _10._Top_Number {
    class Program {
        static void Main(string[] args) {
            int input = Convert.ToInt32(Console.ReadLine());

            PrintTopNumbers(input);
        }

        private static void PrintTopNumbers(int input) {
            for (int i = 1; i < input; i++)
                if (SumOfDigits(i) % 8 == 0 && HasOdd(i))
                    Console.WriteLine(i);
        }

        private static bool HasOdd(int num) {
            char[] digits = num.ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++)
                if (digits[i] % 2 == 0)
                    continue;
                else
                    return true;

            return false;
        }

        private static int SumOfDigits(int num) {
            int sum = 0;

            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}