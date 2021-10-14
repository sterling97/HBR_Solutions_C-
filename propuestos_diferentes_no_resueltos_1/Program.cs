//1) El usuario tecleará dos números (x e y), y el programa deberá calcular cual es el resultado de su
//división y el resto de esa división.


using System;

namespace propuestos_diferentes_no_resueltos_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string linea;
            int division, residue, first_value, second_value;


            Console.Write("Digite el primer numero: "); linea= Console.ReadLine();
            first_value = int.Parse(linea);
            Console.Write("Digite el segundo numero: "); linea= Console.ReadLine();
            second_value = int.Parse(linea);

            Console.WriteLine();
            division = first_value / second_value;
            Console.WriteLine($"El resultado de la division es: {division} ");
            residue = first_value % second_value;
            Console.WriteLine("El resto de la division es: {0} ", residue );

        }
    }
}
