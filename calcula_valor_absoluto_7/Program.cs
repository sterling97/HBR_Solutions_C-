//7) Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número
//de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará
//cambiado de signo.

//funcion que multiplique el numero por -1 si es un numero negativo
//para que despues por ley de los signos cambie a positivo



using System;

namespace calcula_valor_absoluto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            int firs_value, converter_to_absolute_value;

            Console.Write("Digite el primer numero: "); value = Console.ReadLine();
            firs_value = int.Parse(value);
            Console.WriteLine();

            if (firs_value < 0)
            {
                converter_to_absolute_value = firs_value * -1;
                Console.Write("El valor absoluto de {0} es: {1}", firs_value, converter_to_absolute_value);
            }
            else
            {
                Console.Write("El valor absoluto de {0} es {0}", firs_value);
            }
        }
    }
}
