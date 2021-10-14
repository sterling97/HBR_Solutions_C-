using System;

namespace invertir_numeros_dos_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            string usr_numbers;
            int reverse_number, DIVIDE, UNI, reversed_number;
            Console.WriteLine ("INGRESE NÚMERO DE DOS CIFRAS : ");
            usr_numbers = Console.ReadLine();
            reverse_number = int.Parse(usr_numbers);
            DIVIDE = reverse_number/10;
            UNI = reverse_number % 10;
            reversed_number = (UNI * 10) + DIVIDE;
            Console.WriteLine("NÚMERO INVERTIDO ES: " + reversed_number);
            Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
