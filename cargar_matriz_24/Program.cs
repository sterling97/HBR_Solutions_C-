//24) Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los cuatro valores que se
//encuentran en los vértices de la misma (mat[0][0] etc.)



using System;

namespace cargar_matriz_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int indiceFila, indiceCol, tamFilas, tamCol;

            Console.Write("Cuantas Filas tendra la matriz? ");
            tamFilas = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Cuantas Columnas tendra la matriz? ");
            tamCol = Convert.ToInt32(Console.ReadLine());

            int [,] matrizUsuario = new int [tamFilas, tamCol];
            for (indiceFila = 0; indiceFila < tamFilas; indiceFila++)
            {
                for (indiceCol = 0; indiceCol < tamCol; indiceCol++)
                {
                    Console.Write("Ingresa el dato del indice [" + indiceFila + "," + indiceCol + "]: ");
                    matrizUsuario[indiceFila, indiceCol] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Los datos que ingresaste son: ");
            for (indiceFila = 0; indiceFila < tamFilas; indiceFila++)
            {
                for (indiceCol = 0; indiceCol < tamCol; indiceCol++)
                {
                    Console.Write("[" + matrizUsuario[indiceFila,indiceCol] + "]");
                }
                Console.WriteLine();
            }


            Console.ReadKey(true);













        }
    }
}
