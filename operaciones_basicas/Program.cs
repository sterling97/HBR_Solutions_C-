using System;

namespace operaciones_basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_value, user_value2, operations;
            string linea;
            Console.Write("PRIMER NÚMERO :"); 
            linea = Console.ReadLine();
            user_value = int.Parse(linea);
            Console.Write("SEGUNDO NÚMERO :");
            linea = Console.ReadLine();
            user_value2 = int.Parse(linea);
            Console.WriteLine();

            operations = user_value + user_value2;
            Console.WriteLine("LA SUMA ES: " + operations);
            operations = user_value -  user_value2;
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", user_value, user_value2, operations);
            operations = user_value * user_value2;
            Console.WriteLine("LA OPERACION {0} * {1} = {2} ", user_value, user_value2, operations);
            operations = user_value / user_value2;
            Console.WriteLine("LA OPERACION {0} / {1} = {2} ", user_value, user_value2, operations);
            operations = user_value % user_value2;
            Console.WriteLine("EL RESIDUO ES: " + operations);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();




        }
    }
}
