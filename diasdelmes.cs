using System;

class Program
{
    static void Main()
    {
        // Día de la semana correspondiente al primer día del mes de marzo de 2022
        string primerDia = "martes";

        // Días de la semana en orden
        string[] diasSemana = { "lunes", "martes", "miércoles", "jueves", "viernes", "sábado", "domingo" };

        // Encontrar el índice del primer día ingresado en el arreglo de días de la semana
        int indicePrimerDia = Array.IndexOf(diasSemana, primerDia);

        // Solicitar al usuario que ingrese una fecha del mes de marzo
        Console.WriteLine("Ingrese una fecha del mes de marzo:");
        int dia = Convert.ToInt32(Console.ReadLine());

        // Calcular el día de la semana para la fecha ingresada utilizando el algoritmo de Zeller
        int diaSemana = (dia + indicePrimerDia - 1) % 7;

        // Mostrar el día de la semana correspondiente a la fecha ingresada
        Console.WriteLine($"El {dia} de marzo de 2022 fue un {diasSemana[diaSemana]}.");
    }
}

