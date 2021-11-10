using System;

namespace _04._Password_Validator {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            if (!IsValidLength(input))
                Console.WriteLine("Password must be between 6 and 10 characters");
            if (!IsLettersAndDigitsOnly(input))
                Console.WriteLine("Password must consist only of letters and digits");
            if (!IsAtLeast2Digits(input))
                Console.WriteLine("Password must have at least 2 digits");

            if (IsValidLength(input) && IsLettersAndDigitsOnly(input) && IsAtLeast2Digits(input))
                Console.WriteLine("Password is valid");
        }

        private static bool IsValidLength(string input) {
            if (input.Length < 6 || input.Length > 10)
                return false;
            return true;
        }

        private static bool IsLettersAndDigitsOnly(string input) {
            foreach (char ch in input)
                if (!Char.IsLetterOrDigit(ch))
                    return false;
            return true;
        }

        private static bool IsAtLeast2Digits(string input) {
            int digits = 0;

            foreach (char ch in input)
                if (Char.IsDigit(ch))
                    digits++;

            if (digits < 2)
                return false;
            return true;
        }
    }
}