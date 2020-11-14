using System;
using System.IO;

namespace tenttiohjelmointi1
{
    class Program
    {
        static void Main(string[] args)
        {

            double paivansumma;
            while (true) {
                paivansumma = 0;
                Console.WriteLine("Asutko yksin(1) vai puolison kanssa(2):");
                string puoliso = Console.ReadLine();
                if (puoliso == "1")
                {
                    paivansumma += 16.18;
                } else if (puoliso == "2")
                {
                    paivansumma += 13.76*2;
                }
                Console.WriteLine("Onko sinulla/ teillä alaikäisiä lapsia(k/e) :");
                string lapsia = Console.ReadLine();

                if(lapsia.Equals("k"))
                {
                    if(puoliso == "1")
                    {
                        paivansumma += 1.62; // otetaan mukaan yksinhuoltajuus jos puolisuus on 1, 17.18-16.18 = 1.62
                    }
                    Console.WriteLine("Kuinka monta alle 10 - vuotiasta lasta:");
                    int alle10v = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kuinka monta 10 - 17 - vuotiasta lasta:");
                    int kym_17v = int.Parse(Console.ReadLine());

                    paivansumma += 10.20 * alle10v;
                    paivansumma += 11.33 * kym_17v;
                }

                Console.WriteLine("Kuinka monelle päivälle tuki lasketaan?");
                int paivat = int.Parse(Console.ReadLine());

                Console.WriteLine("Saat toimeentulotukea {0} euroa", paivansumma*paivat);

                Console.WriteLine("Haluatko laskea toimeentulotuen uusilla tiedoilla(k/e)");
                string jatketaanko = Console.ReadLine();
                if(jatketaanko.Equals("k"))
                {
                    continue;
                } else
                {
                    break;
                }

            }
        }
    }
}
