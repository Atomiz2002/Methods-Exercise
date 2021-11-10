using System;

namespace _03._Characters_in_Range {
    class Program {
        static void Main(string[] args) {
            char start = Console.ReadLine().ToCharArray()[0];
            char end = Console.ReadLine().ToCharArray()[0];

            CharactersInRange(start, end);
        }

        static void CharactersInRange(char start, char end) {
            for (int i = Math.Min(start, end) + 1; i < Math.Max(start, end); i++)
                Console.Write((char) i + " ");
        }
    }
}