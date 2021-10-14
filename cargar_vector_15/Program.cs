//15) Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite 
//dentro del vector.



using System;

namespace cargar_vector_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = {4, 3, 7, 10, 1, 5, 7};

            int maximo = valores[0];
            int menor = valores[0];
            int repetido = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                
                if (valores[i] < menor)
                {
                    menor = valores[i];
                }
                if (valores[i] == valores[i])
                {
                    repetido = valores[i];
                }
            }
            
            Console.WriteLine("El menor vector es: " + menor);
            Console.WriteLine("El numero que se repite es: " + repetido);
            Console.ReadLine();
        }
    }
}
