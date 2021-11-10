using System;

namespace methods_ex_2._2_ {
    class Program {
        static void Main(string[] args) {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            CoordinatesCloserToCenter(x1, y1, x2, y2);
        }

        private static void CoordinatesCloserToCenter(int x1, int y1, int x2, int y2) {
            int firstCoordinates = Math.Abs(x1 * y1);
            int secondCoordinates = Math.Abs(x2 * y2);

            if (firstCoordinates < secondCoordinates) {
                Console.WriteLine($"({x1}, {y1})");
            } else {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}