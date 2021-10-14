// 5) Crear un programa que pida una letra al usuario y diga si se trata de una vocal.


using System;

namespace identifica_vocal_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vocal;

            
            Console.Write("Introduzca una letra: ");
            vocal = Console.ReadLine().ToUpper();


            if (vocal == "A")
            {
                Console.WriteLine("La letra '{0}' es vocal", vocal);
            }
            else if (vocal == "E")
            {
                Console.WriteLine("La letra '{0}' es vocal", vocal);
            }
            else if (vocal == "I")
            {
                Console.WriteLine("La letra '{0}' es vocal", vocal);
            }
            else if (vocal == "O")
            {
                Console.WriteLine("La letra '{0}' es vocal", vocal);
            }
            else if (vocal == "U")
            {
                Console.WriteLine("La letra '{0}' es vocal", vocal);
            }
            else
            {
                Console.WriteLine("La letra '{0}' NO es una vocal", vocal);
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
