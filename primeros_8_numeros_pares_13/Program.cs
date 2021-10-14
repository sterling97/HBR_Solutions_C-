//13) Crear un programa que muestre los primeros ocho números pares (pista: en cada pasada habrá que
//aumentar de 2 en 2, o bien mostrar el doble del valor que hace de contador).



using System;

namespace primeros_8_numeros_pares_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;

            count = 0;

            while (count < 16)
            {
                count += 2;
                Console.Write("{0},", count);
            }
        }
    }
}
