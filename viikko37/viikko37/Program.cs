using System;

namespace viikko37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halkaisija:");
            double halkaisija = double.Parse(Console.ReadLine());
            Console.WriteLine("1 = ympyrän piiri, 2 = pinta-ala");
            int luku = int.Parse(Console.ReadLine());
            double tulos;
            double sade = halkaisija / 2;
            if (luku == 1)
            {
                tulos = 2 * Math.PI * sade;
                Console.WriteLine("Piiri: {0}", tulos);
            }
            else if (luku == 2)
            {
                tulos = Math.PI * Math.Pow(sade, 2);
                Console.WriteLine("Pinta-ala: {0}", tulos);
            }

            Console.WriteLine("------------------------");
            tulos = luku==1 ? (2 * Math.PI * sade) : (Math.PI * Math.Pow(sade, 2));
            Console.WriteLine(luku == 1 ? "Piiri: "+tulos : "Pinta-ala: "+tulos);

        }
    }
}
