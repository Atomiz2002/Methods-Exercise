using System;
using System.Linq;

namespace _09._Palindrome_Integers {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            while (input != "END") {
                IsPalindrome(input);

                input = Console.ReadLine();
            }
        }

        static void IsPalindrome(string input) {
            char[] num = input.ToCharArray();
            char[] rev = input.ToCharArray();
            Array.Reverse(rev);

            Console.WriteLine((new string(num) == new string(rev)).ToString().ToLower());
        }
    }
}