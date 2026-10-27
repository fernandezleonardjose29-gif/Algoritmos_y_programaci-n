using System;
using System.Xml;

namespace Sistema
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            double espacioDisco = 0;
            do
            {
                Console.WriteLine("Ingrese el espacio total disponible en disco (MB):");
                if (!double.TryParse(Console.ReadLine(), out espacioDisco) || espacioDisco <= 0)
                {
                    Console.WriteLine(">> Espacio inválido. Debe ser mayor a 0.\n");
                    espacioDisco = 0;
                }
            } while (espacioDisco <= 0);

            int cantidadArch = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de archivos a descargar:");
                if (!int.TryParse(Console.ReadLine(), out cantidadArch) || cantidadArch <= 0)
                {
                    cantidadArch = 0;
                }
            } while (cantidadArch <= 0);

            int archivosDescargados = 0;
            double totalMB = 0;

            for (int i = 1; i <= cantidadArch; i++)
            {
                Console.WriteLine($"\nArchivo #{i} - Nombre (escriba 'salir' para detener):");
                string nombre = Console.ReadLine()?.Trim() ?? string.Empty;

                if (nombre.ToLower() == "salir")
                {
                    Console.WriteLine(">> Proceso de descarga cancelado!!");
                    break;
                }

                if (string.IsNullOrEmpty(nombre) || nombre.Length > 20)
                {
                    Console.WriteLine(">> Nombre de archivo inválido. Omitido.");
                    continue;
                }

                Console.WriteLine("Tamaño en MB:");
                double tamanio = 0;
                if (!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0)
                {
                    Console.WriteLine(">> Tamaño inválido. Archivo omitido");
                    continue;
                }

                if (tamanio > espacioDisco)
                {
                    Console.WriteLine(">> Espacio insuficiente en disco. Descarga detenida.");
                    break;
                }

                espacioDisco -= tamanio;

                string categoria = tamanio < 1 ? "Pequeño" : (tamanio <= 10 ? "Mediano" : "Grande");

                Console.WriteLine($">> Descargando '{nombre}' ({tamanio} MB) - Categoría: {categoria}... OK");
                archivosDescargados++;
                totalMB += tamanio;
            }

            Console.WriteLine("\n========== RESUMEN DE DESCARGA ==========");
            Console.WriteLine($"Archivos Descargados: {archivosDescargados}");
            Console.WriteLine($"Total Descargado: {totalMB} MB");
            Console.WriteLine($"Espacio restante en disco: {espacioDisco} MB");
            Console.WriteLine("========================================");
        }
    }
}
