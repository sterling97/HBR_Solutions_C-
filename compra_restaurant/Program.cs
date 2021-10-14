using System;

namespace compra_restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            byte DRINKS, HAMBURGER, CHIPS;
             double to_pay;
             string linea;
             const double drinks_price = 0.8;
             const double burgers_price = 2;
             const double chips_price = 1.2;
             Console.Write("Cuantas hamburguesas desea?: ");linea = Console.ReadLine();
             HAMBURGER = byte.Parse (linea);
             Console.Write("Cuantas papas fritas desea?: ");linea = Console.ReadLine();
             CHIPS = byte.Parse (linea);
             Console.Write("Cuantas bebidas desea?: ");linea = Console.ReadLine();
             DRINKS = byte.Parse (linea);
             Console.WriteLine();
             to_pay = (HAMBURGER * burgers_price) + (CHIPS * chips_price) + (DRINKS * drinks_price);
             Console.WriteLine("VALOR A PAGAR: " + to_pay);
             Console.Write("Pulse una Tecla:");Console.ReadLine();
        }
    }
}
