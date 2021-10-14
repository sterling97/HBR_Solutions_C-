//22) Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
//Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular para
//cargar los días que han faltado cada empleado (cargar el número de día que faltó)
//Cada fila de la matriz representan los días de cada empleado.
//Mostrar los empleados con la cantidad de inasistencias.
//Cuál empleado faltó menos días.




using System;

namespace administrar_dias_empleados_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employee, absence_from_work;

            employee = new string[5];
            absence_from_work = new string[5];

            employee[0] = "Jose";
            employee[1] = "Carmen";
            employee[2] = "Juana";


            absence_from_work[0] = "3";
            absence_from_work[1] = "1";
            absence_from_work[2] = "2";


            
            Console.WriteLine($"Inasistencias de empleados: {employee[0]} ha faltado {absence_from_work[0]} veces. \n" + 
                                $"Inasistencias de empleados: {employee[1]} ha faltado {absence_from_work[1]} veces. \n" +
                                $"Inasistencias de empleados: {employee[2]} ha faltado {absence_from_work[2]} veces. \n");
            Console.WriteLine();
        }
    }
}
