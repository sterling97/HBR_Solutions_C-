//12) Crear un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá
//que descontar 1, por ejemplo haciendo i=i-1, que se puede abreviar i--).


using System;

namespace numeros_descendiendo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            count = 16;

            while (count > 5)
            {
                count -= 1;
                Console.Write("{0},", count);
            }
        }
    }
}
