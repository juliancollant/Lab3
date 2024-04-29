using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingresa un número:");
        // Leer la entrada del usuario como una cadena
        string input = Console.ReadLine();
        // Convertir la entrada en un número entero
        if (int.TryParse(input, out int numero))
        {
            Console.WriteLine($"El número ingresado es: {numero}");
            // Mostrar los múltiplos de 10 del número ingresado
            Console.WriteLine("Múltiplos de 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("Error: Por favor, ingresa un número válido.");
        }
    }
}
