using System;

namespace viikko3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mista, mihin, askellus;
            Console.WriteLine("Mista:");
            mista = int.Parse(Console.ReadLine());
            Console.WriteLine("Mihin:");
            mihin = int.Parse(Console.ReadLine());
            Console.WriteLine("Askellus");
            askellus = int.Parse(Console.ReadLine());
            if (askellus > 0)
            {
                int i;
                i = mista;
                Console.WriteLine("While");
                while (i <= mihin)
                {
                    Console.Write("{0} ", i);
                    i += askellus;
                }
                Console.WriteLine("");
                Console.WriteLine("For");
                for(i=mista;i<=mihin;i+=askellus)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine("");
                Console.WriteLine("Do while");
                i = mista;
                do
                {
                    Console.Write("{0} ", i);
                    i += askellus;
                } while (i <= mihin);
                Console.WriteLine("");
            }
        }
    }
}
