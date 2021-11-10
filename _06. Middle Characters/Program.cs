using System;

namespace _06._Middle_Characters {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            Console.WriteLine(MiddleCharacters(input));
        }

        private static string MiddleCharacters(string input) {
            // 1 2 >3 4< 5 6
            // 1 2 >3< 4 5
            char[] chars = input.ToCharArray();

            if (input.Length % 2 == 0) {
                char char1 = chars[chars.Length / 2 - 1];
                char char2 = chars[chars.Length / 2];
                return String.Concat(char1, char2);
            } else {
                return chars[chars.Length / 2].ToString();
            }
        }
    }
}