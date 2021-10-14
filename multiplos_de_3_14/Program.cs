//14) Crear un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3 (pista:
//habrá que recorrer todos esos números y ver si el resto de la división entre 3 resulta 0).



using System;

namespace multiplos_de_3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiple;

            multiple = 0;

            while (multiple < 50)
            {
                multiple += 1;
                if (multiple % 3 == 0)
                {
                    Console.Write("{0},", multiple);
                }
            }
        }
    }
}
