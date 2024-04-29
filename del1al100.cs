using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mostrando números del 0 al 100 usando diferentes estructuras:");

        // Usando la estructura while
        Console.WriteLine("\nUsando la estructura while:");
        int i = 0;
        while (i <= 100)
        {
            Console.Write($"{i} ");
            i++;
        }

        // Usando la estructura do-while
        Console.WriteLine("\n\nUsando la estructura do-while:");
        int j = 0;
        do
        {
            Console.Write($"{j} ");
            j++;
        } while (j <= 100);

        // Usando la estructura for
        Console.WriteLine("\n\nUsando la estructura for:");
        for (int k = 0; k <= 100; k++)
        {
            Console.Write($"{k} ");
        }

        // Usando la estructura foreach
        Console.WriteLine("\n\nUsando la estructura foreach:");
        int[] numeros = new int[101]; // Creamos una matriz de 101 elementos
        for (int m = 0; m <= 100; m++)
        {
            numeros[m] = m; // Llenamos la matriz con los números del 0 al 100
        }
        foreach (int numero in numeros) // Iteramos sobre la matriz y mostramos cada número
        {
            Console.Write($"{numero} ");
        }

        Console.WriteLine("\n\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
