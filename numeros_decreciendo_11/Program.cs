//11) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo),
//usando "do..while"



using System;

namespace numeros_decreciendo_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            count = 28;

            do
            {
                count -= 2;
                Console.WriteLine("{0}", count);
            }
            while (count > 10);
        }
    }
}
