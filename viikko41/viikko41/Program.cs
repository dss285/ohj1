using System;
using System.IO;
namespace viikko41
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==0)
            {
                Console.WriteLine("Ei annettu parametrejä");
                return;
            } else
            {
                string tiedosto = "c:/temp/parametrit.txt";
                Tallenna(args, tiedosto);
                LueJaTulosta(tiedosto);
            }
        }
        public static void Tallenna(string[] args, string tiedosto)
        {
            StreamWriter writer = new StreamWriter(tiedosto);
            foreach(string x in args)
            {
                writer.WriteLine(x);
            }
            writer.Close();
        }
        public static void LueJaTulosta(string tiedosto)
        {
            StreamReader reader = new StreamReader(tiedosto);
            string br = reader.ReadLine();
            while(br != null) {
                Console.WriteLine(br);
                br = reader.ReadLine();
            }
            reader.Close();
        }

    }
}
