// 9) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando
//"while"



using System;

namespace des_escribe_numero_con_while_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cap_1, cap_2;
            

            cap_1 = 28;
            cap_2 = 10;

            while (cap_1 > cap_2)
            {
                cap_1 -= 2;
                Console.Write("{0},", cap_1);  
            }
        }
    }
}
