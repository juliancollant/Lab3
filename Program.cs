using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora Simple\n");

        while (true)
        {
            // Mostrar opciones de operación
            Console.WriteLine("Elija la operación que desea realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Resto");
            Console.WriteLine("6. Salir");

            // Leer la opción del usuario
            Console.Write("Ingrese el número de la operación: ");
            string opcion = Console.ReadLine();

            if (opcion == "6")
            {
                Console.WriteLine("¡Gracias por usar la calculadora!");
                return; // Salir del programa si el usuario elige la opción "6"
            }

            // Leer los números ingresados por el usuario
            Console.Write("Ingrese el primer número: ");
            double num1;
            bool conversionExitosa = double.TryParse(Console.ReadLine(), out num1); // Intentar convertir la entrada del usuario en un número

            if (!conversionExitosa)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                Console.WriteLine("\nPresione cualquier tecla para continuar..."); // Esperar a que el usuario presione cualquier tecla
                Console.ReadKey(); // Leer la tecla que presiona el usuario
                Console.Clear(); // Limpiar la consola para una nueva entrada
                continue; // Volver al inicio del bucle while
            }

            Console.Write("Ingrese el segundo número: ");
            double num2;
            conversionExitosa = double.TryParse(Console.ReadLine(), out num2); // Intentar convertir la entrada del usuario en un número

            if (!conversionExitosa)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                Console.WriteLine("\nPresione cualquier tecla para continuar..."); // Esperar a que el usuario presione cualquier tecla
                Console.ReadKey(); // Leer la tecla que presiona el usuario
                Console.Clear(); // Limpiar la consola para una nueva entrada
                continue; // Volver al inicio del bucle while
            }

            double resultado = 0;

            // Realizar la operación seleccionada por el usuario
            switch (opcion)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    break;
                case "5":
                    resultado = num1 % num2;
                    Console.WriteLine($"El resultado del resto es: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar..."); // Esperar a que el usuario presione cualquier tecla
            Console.ReadKey(); // Leer la tecla que presiona el usuario
            Console.Clear(); // Limpiar la consola para una nueva entrada
        }
    }
}
