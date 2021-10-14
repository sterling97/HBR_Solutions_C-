//6) Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo",
//"Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda.


using System;

namespace analiza_signos_numericos_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int firs_value, second_value;
            

            Console.Write("Digite el primer numero: "); line= Console.ReadLine();
            firs_value = int.Parse(line);

            Console.Write("Digite el segundo numero: "); line= Console.ReadLine();
            second_value = int.Parse(line);
            Console.WriteLine();

            if (firs_value < 0 && second_value > 0)
            {
                Console.Write("Uno de los números es positivo");
            }
            else if (firs_value > 0 && second_value < 0)
            {
                Console.Write("Uno de los números es positivo");
            }
            else if (firs_value > 0 && second_value > 0)
            {
                Console.Write("Los dos números son positivos");
            }
            else
            {
               Console.Write("Ninguno de los números es positivo");
            }          
        }
    }
}
