using System;

namespace LuckyTickets
{
    class Program
    {
        // Посчтитать количество счастливых билетиков
        static void Main(string[] args)
        {
            // 1 вариант
            int lucky = 0;
            for (int i = 0; i < 1000000; i++)
            {
                int current = i;
                int[] n = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    n[j] = current % 10;
                    current = current / 10;
                }
                if (n[0] + n[1] + n[2] == n[3] + n[4] + n[5]) lucky++;
            }
            Console.WriteLine("1. Счастливых билетиков {0} штучек", lucky);

            // 2 вариант
            lucky = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                    if ((i / 100) + (i / 10 % 10) + (i % 10) == (j / 100) + (j / 10 % 10) + (j % 10)) lucky++;
            }
            Console.WriteLine("2. Счастливых билетиков {0} штучек", lucky);

            // 3 вариант
            lucky = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int p = 0; p < 10; p++)
                    {
                        for (int q = 0; q < 10; q++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int n = 0; n < 10; n++)
                                    if (i + j + p == q + m + n) lucky++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("3. Счастливых билетиков {0} штучек", lucky);
        }
    }
}
