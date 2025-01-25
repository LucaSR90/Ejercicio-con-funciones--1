using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa un año:");

        // Validamos la entrada del usuario
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            // Verificamos si el año es bisiesto
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"{year} no es un año bisiesto.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}
