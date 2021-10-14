//4) Crear un programa que pida al usuario dos números reales. Si el segundo no es cero, mostrará el
//resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero,
//escribirá “Error: No se puede dividir entre cero”



using System;

namespace dividir_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int firs_value, second_value, divide;

            Console.Write("Digite el primer numero: "); line= Console.ReadLine();
            firs_value = int.Parse(line);

            Console.Write("Digite el segundo numero: "); line= Console.ReadLine();
            second_value = int.Parse(line);
            Console.WriteLine();

            while (second_value == 0)
            {
                Console.Write("Error: No se puede dividir entre cero");
                Console.WriteLine();
                Console.Write("Digite el segundo numero: "); line= Console.ReadLine();
                second_value = int.Parse(line);
            }

            divide = firs_value / second_value;
            Console.Write("El resultado es: {0}", divide);
        }
    }
}
