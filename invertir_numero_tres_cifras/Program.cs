using System;

namespace invertir_numero_tres_cifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse_number, reversed_number, DIVIDE_DEC, UNI, DIVIDE_CEN;
             string usr_numbers;
             Console.WriteLine ("INGRESE NÚMERO DE TRES CIFRAS :"); 
             usr_numbers = Console.ReadLine();
             reverse_number = int.Parse(usr_numbers);
             DIVIDE_CEN = reverse_number /100;
             reverse_number = reverse_number % 100;
             DIVIDE_DEC = reverse_number/10;
             UNI = reverse_number % 10;
             reversed_number = (UNI * 100) + (DIVIDE_DEC * 10) + DIVIDE_CEN;
             Console.WriteLine("NÚMERO INVERTIDO ES: " + reversed_number);
             Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();

        }
    }
}
