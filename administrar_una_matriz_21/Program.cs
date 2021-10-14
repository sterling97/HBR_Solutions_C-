//21) Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 2
//columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila (crearla sin la intervención
//del operador)
//Realizar la carga por teclado e imprimir posteriormente.



using System;

namespace administrar_una_matriz_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int fila, columna;

            Console.Write("Digite el numero de filas: "); valor= Console.ReadLine();
            fila = int.Parse(valor);

           Console.Write("Digite el numero de columnas: "); valor= Console.ReadLine();
           columna = int.Parse(valor);

            int[,] matrix = new int[fila, 2];

            
            for (int filas = 0; filas < matrix.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrix.GetLength(1); columnas++)
                {
                    matrix[filas, columnas] = 300 * (filas + 3) * (columnas + 4);
                }
            }

            for (int filas = 0; filas < matrix.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrix.GetLength(1); columnas++)
                {
                    Console.WriteLine("La pocicion es: " + filas + "," + columnas + "=" + matrix[filas, columnas].ToString());
                }
            }
        }
    }
}
