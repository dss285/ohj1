using System;

namespace viikko40
{
    class Program
    {

        static void Main(string[] args)
        {
            double hypynpituus = 0.0;
            double[] tuomaripisteet = new double[5];
            double pisteet = 0.0;
            KysyHypynPituus(out hypynpituus);
            KysyTuomareidenPisteet(ref tuomaripisteet);
            Array.Sort(tuomaripisteet);
            LaskeHypynPisteet(out pisteet, ref tuomaripisteet, ref hypynpituus);
            Tulosta(ref hypynpituus, ref pisteet);
        }
        static void KysyHypynPituus(out double hypynpituus)
        {
            Console.WriteLine("Hypyn pituus");
            hypynpituus = Math.Round(Double.Parse(Console.ReadLine()) * 2) / 2;
        }
        static void KysyTuomareidenPisteet(ref double[] tuomaripisteet)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Tuomari {0}", i + 1);
                double luku = Double.Parse(Console.ReadLine());
                if (luku >= 0 && luku <= 20)
                {
                    tuomaripisteet[i] = Math.Round(luku * 2) / 2;
                    i++;
                }
            }
        }
        static void LaskeHypynPisteet(out double pisteet, ref double[] tuomaripisteet, ref double hypynpituus)
        {
            const double kriittinenpiste = 90;
            pisteet = (hypynpituus - kriittinenpiste) * 1.8 + (tuomaripisteet[1]
                 + tuomaripisteet[2] + tuomaripisteet[3]) + 60;
        }
        static void Tulosta(ref double hypynpituus, ref double pisteet)
        {
            Console.WriteLine("{0}m ja {1} pistettä", hypynpituus, pisteet);
        }
    }
}