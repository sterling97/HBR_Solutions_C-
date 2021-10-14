// 2) Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del
// segundo (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b == 0).


using System;

namespace validar_multiplos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int division, residue, firs_value, second_value;

            Console.Write("Digite el primer numero: "); line= Console.ReadLine();
            firs_value = int.Parse(line);
            Console.Write("Digite el segundo numero: "); line= Console.ReadLine();
            second_value = int.Parse(line);

            Console.WriteLine();
            division = firs_value / second_value;
            residue = firs_value % second_value;
            
            if (residue == 0)
            {
                Console.Write("{0} es multiplo de {1} ", firs_value, second_value ); line= Console.ReadLine();
            }
            else
            {
                Console.Write("{0} no es multiplo de {1} ", firs_value, second_value ); line= Console.ReadLine();
            }

        }
    }
}
