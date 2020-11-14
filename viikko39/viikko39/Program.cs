using System;

namespace viikko39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] taulukko = new int[5, 4];
            for(int i = 0;i<5;i++)
            {
                Console.WriteLine("Päivä {0}", i + 1);
                for(int j = 0;j<4;j++)
                {
                    Console.WriteLine("Mittaus {0}", j + 1);
                    taulukko[i, j] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }

            for(int i = 0;i<5;i++)
            {
                int avg = 0;
                for(int j = 0;j<4; j++)
                {
                    avg += taulukko[i, j];
                }
                string[] paivat = new string[5];
                paivat[0] = "Maanantai";
                paivat[1] = "Tiistai";
                paivat[2] = "Keskiviikko";
                paivat[3] = "Torstai";
                paivat[4] = "Perjantai";
                Console.WriteLine("{0} : {1} mm",paivat[i], (double)avg/4.0);

            }
        }
    }
}
