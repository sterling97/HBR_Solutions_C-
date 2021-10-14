using System;

namespace nombre_paises_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = new string[]
            {
            "Republica Dominicana",
            "Canada",
            "Alemania",
            "Haiti",
            "El Salvador"
            };
            
            Array.Sort(countries);
        
            foreach (string contry in countries)
            {
                Console.WriteLine(contry);
            }
        }
    }
}
