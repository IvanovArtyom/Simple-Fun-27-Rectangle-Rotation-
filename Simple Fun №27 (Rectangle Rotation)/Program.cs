using System;

namespace myjinxin
{
    public class Kata
    {
        public static void Main()
        {
            Kata test = new();

            // Test
            var t = test.RectangleRotation(6, 4);
            // ...should return 23
        }

        readonly double cellLength = Math.Sqrt(2);

        public int RectangleRotation(int a, int b)
        {
            return CalcFullCellsNumber(a) * CalcFullCellsNumber(b) + CalcHalfCellsNumber(a) * CalcHalfCellsNumber(b);
        }

        public int CalcFullCellsNumber(int n)
        {
            return (int)(n / 2d / cellLength) * 2 + 1;
        }

        public int CalcHalfCellsNumber(int n)
        {
            return ((int)((n / 2d - cellLength / 2) / cellLength) + 1) * 2;
        }
    }
}