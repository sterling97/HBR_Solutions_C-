//23) Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la primer fila con la segundo.
//Imprimir luego la matriz.



using System;

namespace crear_matriz_23
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[][] {
                new int[]{  1,  2,  3,  4,  5 },
                new int[]{  6,  7,  8,  9, 10 },
                new int[]{ 11, 12, 13, 14, 15 },
                new int[]{ 16, 17, 18, 19, 20 },
                new int[]{ 21, 22, 23, 24, 25 },
            };

            Console.WriteLine("Before:");
            PrintMatrix(matrix);

            Console.WriteLine();

            
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for(int x = 0; x < rows / 2; x++)
            {
                for(int y = 0; y < cols; y++)
                {
                    int temp = matrix[x][y];
                    matrix[x][y] = matrix[rows - x - 1][y];
                    matrix[rows - x - 1][y] = temp;
                }
            }
            

            Console.WriteLine("After:");
            PrintMatrix(matrix);

            Console.ReadKey();
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var col in row)
                {
                    var toPrint = col + " ";
                    if (col < 10)
                    {
                        toPrint = "0" + toPrint;
                    }
                    Console.Write(toPrint);
                }

                Console.WriteLine();
            }
        }
    }
}


