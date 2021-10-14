//18) Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de habitantes del
//mismo. Ordenar alfabéticamente e imprimir los resultados. Por último ordenar con respecto a la
//cantidad de habitantes (de mayor a menor) e imprimir nuevamente.



using System;

namespace paises_y_poblacion_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries, population;

            countries = new string[5];
            population = new string[5];

            countries[0] = "Republica Dominicana";
            countries[1] = "Canada";
            countries[2] = "Alemania";
            countries[3] = "Haiti";
            countries[4] = "El Salvador";

            population[0] = "83.02";
            population[1] = "37.59";
            population[2] = "6.454";
            population[3] = "11.26";
            population[4] = "10.74";

            
            Console.WriteLine(countries[0] + " tiene una poblacion aproximada de: " + population[0] + "M de habitantes." );
            Console.WriteLine();
            Console.WriteLine(countries[1] + " tiene una poblacion aproximada de: " + population[1] + "M de habitantes." );
            Console.WriteLine();
            Console.WriteLine(countries[2] + " tiene una poblacion aproximada de: " + population[2] + "M de habitantes." );
            Console.WriteLine();
            Console.WriteLine(countries[3] + " tiene una poblacion aproximada de: " + population[3] + "M de habitantes." );
            Console.WriteLine();
            Console.WriteLine(countries[4] + " tiene una poblacion aproximada de: " + population[4] + "M de habitantes." );



           
           

            










        }
    }
}
