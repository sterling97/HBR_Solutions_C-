// 3) Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un
// primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por
// cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo
// número y se mostrará el producto de ambos.


using System;

namespace multiplicar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int firs_value, second_value, multiplate;

            Console.Write("Digite el primer numero: "); line= Console.ReadLine();
            firs_value = int.Parse(line);

            while (firs_value == 0)
            {
                Console.Write("El producto de 0 por cualquier número es 0");
                Console.WriteLine();
                Console.Write("Digite el primer numero: "); line= Console.ReadLine();
                firs_value = int.Parse(line);
            }

            Console.Write("Digite el segundo numero: "); line= Console.ReadLine();
            second_value = int.Parse(line);
            Console.WriteLine();
            multiplate = firs_value * second_value;
            Console.Write("El resultado es: {0}", multiplate);
        }
    }
}
