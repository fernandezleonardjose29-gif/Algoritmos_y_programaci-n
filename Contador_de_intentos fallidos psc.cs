using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        const string passCorrecta = "Leo123";
        string clave;
        int intentosFallido = 0;

        do
        {
            Console.WriteLine("Ingrese la contraseña");
            clave = Console.ReadLine();
            if (clave != passCorrecta)
            {
                intentosFallido++;
                Console.WriteLine("Contraseña incorrecta. Inténtalo de nuevo.");
            }

        } while (clave != passCorrecta);

        Console.WriteLine($"\n Acceso concedido.");
        Console.WriteLine($" Intentos Fallido: {intentosFallido}");
    }
}
