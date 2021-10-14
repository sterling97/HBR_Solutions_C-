//19) Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir
//primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)


using System;

namespace crear_matriz_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 5];

            
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
