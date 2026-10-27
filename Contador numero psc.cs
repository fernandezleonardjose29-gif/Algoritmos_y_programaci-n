// pide numeros enteros y acumula  su suma hasta que ingrese 0. muestra la suma de total. cuantos numeros se ingresaron y el promedio 



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int numero;
        int suma = 0;
        int contador = 0;

        do
        {
            Console.WriteLine("Ingrese un numero (0 para salir)");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                suma += numero;
                contador++;
            }

        } while (numero != 0);

        Console.WriteLine($"\nSuma total: {suma}");
        Console.WriteLine($"\nCantidad de numero es: {contador}");

        if (contador > 0)
        {
            Console.WriteLine($"Promedio: {(double)suma / contador:F2}");
        }
        else
        {
            Console.WriteLine($"No se ingresaron numeros.");
        }
    }
}