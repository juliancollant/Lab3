using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = new int[4];
        bool arregloCargado = false;

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Cargar arreglo");
            Console.WriteLine("2. Mostrar arreglo");
            Console.WriteLine("3. Calcular promedio");
            Console.WriteLine("4. Mostrar máximo");
            Console.WriteLine("5. Mostrar mínimo");
            Console.WriteLine("6. Eliminar elemento en posición");
            Console.WriteLine("7. Agregar elemento en posición");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CargarArreglo(arreglo);
                    arregloCargado = true;
                    break;
                case "2":
                    if (arregloCargado)
                    {
                        MostrarArreglo(arreglo);
                    }
                    else
                    {
                        Console.WriteLine("El arreglo no ha sido cargado.");
                    }
                    break;
                case "3":
                    if (arregloCargado)
                    {
                        CalcularPromedio(arreglo);
                    }
                    else
                    {
                        Console.WriteLine("El arreglo no ha sido cargado.");
                    }
                    break;
                case "4":
                    if (arregloCargado)
                    {
                        MostrarMaximo(arreglo);
                    }
                    else
                    {
                        Console.WriteLine("El arreglo no ha sido cargado.");
                    }
                    break;
                case "5":
                    if (arregloCargado)
                    {
                        MostrarMinimo(arreglo);
                    }
                    else
                    {
                        Console.WriteLine("El arreglo no ha sido cargado.");
                    }
                    break;
                case "6":
                    if (arregloCargado)
                    {
                        EliminarElementoEnPosicion(arreglo);
                    }
                    else
                    {
                        Console.WriteLine("El arreglo no ha sido cargado.");
                    }
                    break;
                case "7":
                    if (arregloCargado)
                    {
                        AgregarElementoEnPosicion(arreglo);
                    }
                    else
                    {
                        Console.WriteLine("El arreglo no ha sido cargado.");
                    }
                    break;
                case "8":
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void CargarArreglo(int[] arreglo)
    {
        Console.WriteLine("\nCarga de arreglo:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Arreglo cargado exitosamente.");
    }

    static void MostrarArreglo(int[] arreglo)
    {
        Console.WriteLine("\nArreglo:");
        foreach (var numero in arreglo)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }

    static void CalcularPromedio(int[] arreglo)
    {
        int suma = 0;
        foreach (var numero in arreglo)
        {
            suma += numero;
        }
        double promedio = (double)suma / arreglo.Length;
        Console.WriteLine($"El promedio de los elementos del arreglo es: {promedio}");
    }

    static void MostrarMaximo(int[] arreglo)
    {
        int maximo = int.MinValue;
        foreach (var numero in arreglo)
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
        }
        Console.WriteLine($"El máximo elemento del arreglo es: {maximo}");
    }

    static void MostrarMinimo(int[] arreglo)
    {
        int minimo = int.MaxValue;
        foreach (var numero in arreglo)
        {
            if (numero < minimo)
            {
                minimo = numero;
            }
        }
        Console.WriteLine($"El mínimo elemento del arreglo es: {minimo}");
    }

    static void EliminarElementoEnPosicion(int[] arreglo)
    {
        Console.Write("Ingrese la posición del elemento a eliminar (0-4): ");
        int posicion;
        if (int.TryParse(Console.ReadLine(), out posicion) && posicion >= 0 && posicion < arreglo.Length)
        {
            for (int i = posicion; i < arreglo.Length - 1; i++)
            {
                arreglo[i] = arreglo[i + 1];
            }
            arreglo[arreglo.Length - 1] = 0; // Asignar 0 al último elemento para eliminarlo
            Console.WriteLine("Elemento eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Posición no válida. Debe ser un número entre 0 y 3.");
        }
    }

    static void AgregarElementoEnPosicion(int[] arreglo)
    {
        Console.Write("Ingrese la posición donde desea agregar el elemento (0-9): ");
        int posicion;
        if (int.TryParse(Console.ReadLine(), out posicion) && posicion >= 0 && posicion < arreglo.Length)
        {
            Console.Write("Ingrese el valor del nuevo elemento: ");
            int nuevoElemento = int.Parse(Console.ReadLine());

            // Desplazar los elementos hacia la derecha para hacer espacio para el nuevo elemento
            for (int i = arreglo.Length - 1; i > posicion; i--)
            {
                arreglo[i] = arreglo[i - 1];
            }
            arreglo[posicion] = nuevoElemento;
            Console.WriteLine("Elemento agregado correctamente.");
        }
        else
        {
            Console.WriteLine("Posición no válida. Debe ser un número entre 0 y 9.");
        }
    }
}
