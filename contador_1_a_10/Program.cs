//10) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".



using System;

namespace contador_1_a_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count;

            count = 0;

            do
            {
                count += 1;
                Console.WriteLine("{0}", count);
            }
            while (count < 10);
        }
    }
}
