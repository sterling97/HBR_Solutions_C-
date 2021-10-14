//16) Se debe crear un vector donde almacenar 5 sueldos. 
//Ordenar el vector sueldos de menor a mayor.


using System;

namespace almacenar_sueldos_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salaries = {2500, 8000, 7010, 6200, 3200};

            Array.Sort(salaries);

            for (int i = 0; i < salaries.Length; i++)
            {
                Console.WriteLine(salaries[i]);
            }
            Console.ReadLine();





        }
    }
}
