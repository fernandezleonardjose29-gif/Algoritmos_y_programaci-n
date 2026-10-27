using System;

namespace programa_cm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== menu =====");
            Console.WriteLine("1. saludar");
            Console.WriteLine("2. mostrar fecha");
            Console.WriteLine("3. salir");
            Console.WriteLine("seleccione una opcion");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese su nombre:");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese su edad");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese su genero F/M");
                    string gender = Console.ReadLine();

                    Console.WriteLine("Ingrese su facultad");
                    string faculty = Console.ReadLine();

                    Console.WriteLine("Ingrese su programa academico");
                    string program = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("la fecha actual es: " + DateTime.Now);
                    break;

                case 3:
                    Console.WriteLine("saliendo del programa");
                    break;

                default:
                    Console.WriteLine("Error!! opcion no valida");
                    break;
            }
        }
    }
}
