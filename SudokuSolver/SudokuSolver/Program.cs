using System;

namespace SudokuSolver
{
    class Program
    {
        public static int[,] map;
        static void Main(string[] args)
        {
            map = new int[9, 9];

            ZeroMap();
            FillMap();
            PrintMap();

            Console.ReadLine();
        }
        static void FillMap()
        {
            map[0, 0] = 5;
            map[0, 1] = 3;
            map[0, 0] = 5;
            map[0, 4] = 7;
            map[1, 0] = 6;
            map[1, 3] = 1;
            map[1, 4] = 9;
            map[1, 5] = 5;
            map[2, 1] = 9;
            map[2, 2] = 8;
            map[2, 7] = 6;
            map[3, 0] = 8;
            map[3, 4] = 6;
            map[3, 8] = 3;
            map[4, 0] = 4;
            map[4, 3] = 8;
            map[4, 5] = 3;
            map[4, 8] = 1;
            map[5, 0] = 7;
            map[5, 4] = 2;
            map[5, 8] = 6;
            map[6, 1] = 6;
            map[6, 6] = 2;
            map[6, 7] = 8;
            map[7, 3] = 4;
            map[7, 4] = 1;
            map[7, 5] = 9;
            map[7, 8] = 5;
            map[8, 4] = 8;
            map[8, 7] = 7;
            map[8, 8] = 9;
        }
        static void ZeroMap()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    map[i, j] = 0;
                }
            }
        }
        static void PrintMap()
        {
            for (int i = 0; i < 9; i++)
            {
                int n = 1;
                for (int j = 0; j < 9; j++)
                {
                    if (n % 9 == 0)
                    {
                        Console.WriteLine(map[i, j]);
                    }
                    else
                    {
                        Console.Write(map[i, j] + " ");
                    }
                    n++;
                }
            }
        }
        static void CompleteMap()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                }
            }
        }
        static void CheckNumber(int a, int b)
        {

        }
        static void TryNumber(int a, int b, int c)
        {
            map[a, b] = c;
        }
        static bool ValidBlock(int a, int b)
        {
            if (ValidRow(a, b) && ValidColumn(a, b))
                return true;
            else
                return false;
        }
        static bool ValidRow(int a, int b)
        {
            bool rowValid = true;
            for (int i = 0; i < 9; i++)
            {
                if (map[a, i] == map[a, b] && i != b)
                {
                    rowValid = false;
                }
            }
            return rowValid;
        }
        static bool ValidColumn(int a, int b)
        {
            bool rowValid = true;
            for (int i = 0; i < 9; i++)
            {
                if (map[i, b] == map[a, b] && i != a)
                {
                    rowValid = false;
                }
            }
            return rowValid;
        }
    }
}
