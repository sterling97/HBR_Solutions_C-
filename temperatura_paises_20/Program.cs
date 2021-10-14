//20) Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las
//temperaturas medias mensuales de dichos paises.
//Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
//Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
//a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
//185
//b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
//c - Calcular la temperatura media trimestral de cada país.
//e - Imprimr los nombres de las provincias y las temperaturas medias trimestrales.
//f - Imprimir el nombre de la provincia con la temperatura media trimestral mayor.



using System;

namespace temperatura_paises_20
{
    class Program
    {
        static void Main(string[] args)
        {            


            string[] countries;
            string choice, temperature_canada, temperature_alemania, temperature_francia, temperature_italia;
            int user_choice;

            Console.Write("Seleccione el numero del pais que quiere consultar la temperatura: \n" +
                            "\n" +
                            "1-CANADA \n" +
                            "2-ALEMANIA \n" +
                            "3-FRANCIA \n" +
                            "4-ITALIA \n" +
                            "\n" +
                            "Eleccion: ");

            choice = Console.ReadLine();
            user_choice = int.Parse(choice);

            countries = new string[5];
           

            countries[0] = "CANADA";
            countries[1] = "ALEMANIA";
            countries[2] = "FRANCIA";
            countries[3] = "ITALIA";
            


            temperature_canada = "     \nEnero: Minima = -11°C maxima = -3°C \n" +
                                "Febrero: Minima = -11°C maxima = -2°C \n" +
                                "Marzo: Minima = -6°C maxima = 3°C \n" +
                                "Abril: Minima = 1°C maxima = 11°C \n" +
                                "Mayo: Minima = 6°C maxima = 18°C \n" +
                                "Junio: Minima = 11°C maxima = 23°C \n" +
                                "Julio: Minima = 14°C maxima = 27°C \n" +
                                "Agosto: Minima = 13°C maxima = 25°C \n" +
                                "Septiempre: Minima = 9°C maxima = 21°C \n" +
                                "Octubre: Minima = 3°C maxima = 14°C \n" +
                                "Noviembre: Minima = -1°C maxima = 7°C \n" +
                                "Diciembre: Minima = -8°C maxima = 0°C";

            temperature_alemania =  "\nEnero: Minima = -3°C maxima = 2°C \n" +
                                    "Febrero: Minima = -2°C maxima = 2°C \n" + 
                                "Marzo: Minima = 0°C maxima = 8°C \n" +
                                "Abril: Minima = 4°C maxima = 13°C \n" +
                                "Mayo: Minima = 8°C maxima = 18°C \n" +
                                "Junio: Minima = 11°C maxima = 22°C \n" +
                                "Julio: Minima = 13°C maxima = 23°C \n" +
                                "Agosto: Minima = 12°C maxima = 23°C \n" +
                                "Septiempre: Minima = 9°C maxima = 18°C \n" +
                                "Octubre: Minima = 6°C maxima = 13°C \n" +
                                "Noviembre: Minima = 2°C maxima = 7°C \n" +
                                "Diciembre: Minima = -1°C maxima = 3°C \n";

            temperature_francia = "\nEnero: Minima = 1°C maxima = 6°C \n" +
                                "Febrero: Minima = 1°C maxima = 7°C \n" +
                                "Marzo: Minima = 3°C maxima = 11°C \n" +
                                "Abril: Minima = 6°C maxima = 14°C \n" +
                                "Mayo: Minima = 9°C maxima = 18°C \n" +
                                "Junio: Minima = 12°C maxima = 21°C \n" +
                                "Julio: Minima = 14°C maxima = 21°C \n" +
                                "Agosto: Minima = 14°C maxima = 24°C \n" +
                                "Septiempre: Minima = 11°C maxima = 24°C \n" +
                                "Octubre: Minima = 8°C maxima = 15°C \n" +
                                "Noviembre: Minima = 4°C maxima = 9°C \n" +
                                "Diciembre: Minima = 2°C maxima = 7°C";

            temperature_italia = "La temperatura mensual de Italia: Enero: Minima = 2°C maxima = 12°C \n" +
                                "Febrero: Minima = 3°C maxima = 13°C \n" +
                                "Marzo: Minima = 4°C maxima = 16°C \n" +
                                "Abril: Minima = 7°C maxima = 19°C \n" +
                                "Mayo: Minima = 11°C maxima = 23°C \n" +
                                "Junio: Minima = 14°C maxima = 27°C \n" +
                                "Julio: Minima = 17°C maxima = 31°C \n" +
                                "Agosto: Minima = 17°C maxima = 31°C \n" +
                                "Septiempre: Minima = 14°C maxima = 27°C \n" +
                                "Octubre: Minima = 10°C maxima = 22°C \n" +
                                "Noviembre: Minima = 6°C maxima = 17°C \n" +
                                "Diciembre: Minima = 3°C maxima = 13°C";


                            
            
            if (user_choice == 1)
            {
                Console.WriteLine("La temperatura promedio de " + countries[0] + " es: " + temperature_canada + "\n");
                Console.WriteLine();

            }
            else if (user_choice == 2)
            {
                Console.WriteLine("La temperatura promedio de " + countries[1] + " es: " + temperature_alemania + "\n");
                Console.WriteLine();
            }
            else if (user_choice == 3)
            {
                Console.WriteLine("La temperatura promedio de " + countries[2] + " es: " + temperature_francia + "\n");
                Console.WriteLine();
            }
            else if (user_choice == 4)
            {
                Console.WriteLine("La temperatura promedio de " + countries[3] + " es: " + temperature_italia + "\n");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("ERROR: ingrese el numero del pais que quiere consultar");
                Console.WriteLine();
            }

            Console.WriteLine("La temperatura media trimestral mas alta es: Italia");
            
        }
    }
}
