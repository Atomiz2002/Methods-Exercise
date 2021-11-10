using System;
using System.Linq;

namespace _02._Vowels_Count {
    class Program {
        static void Main(string[] args) {
            VowelsCount(Console.ReadLine());
        }

        static void VowelsCount(string arg1) {
            char[] array = arg1.ToLower().ToCharArray();
            int count = 0;
            for (int i = 0; i < array.Length; i++) {
                switch (array[i]) {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }

            Console.WriteLine(count);
        }
    }
}