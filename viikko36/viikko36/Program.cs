using System;

namespace viikko36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 KT3

Esittele kaksi kokonaislukumuuttujaa ja anna niille arvot esittelyn yhteydessä. Tulosta näiden muuttujien summa, erotus ja tulo alla olevalla tavalla (muuttujien arvot alla olevassa esimerkissä ovat siis 10 ja 5).
Summa : 10 + 5 = 15
Erotus : 10 - 5 = 5
Tulo : 10 * 5 = 50
Tulostukseen voi siis laittaa myös laskutoimituksen, jolloin tulostetaan laskutoimituksen tulos.
 Esimerkiksi alla oleva tulostaa : 3
int luku1 = 1;
int luku2 = 2;
Console.WriteLine("{0}", luku1 + luku2);
PALAUTA VAIN CS-TIEDOSTOT JOKAINEN OMANA TIEDOSTONAAN (3 KPL)!
Tehtävät palautettava viimeistään 15.9 klo 23.55 mennessä
*/
            int luku1 = int.Parse(Console.ReadLine());
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Summa : {0}\nErotus : {1}\nTulo : {3}",luku1+luku2,luku1-luku2,luku1*luku2);

        }
    }
}
