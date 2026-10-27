using System;

public class HelloWorld {
    public static void Main(string[] args) {

        int cantidadArch= 0;

        do{

            Console.WriteLine ("ingrese la cantidad de arechivos a descargar");

            if(!int.TryParse(Console.ReadLine(), out cantidadArch)){
                cantidadArch=0;

            }

        }while(cantidadArch <= 0);

        int archivosDescargados=0;
        double totalMB=0;

        for(int i =1; i<= cantidadArch; i++){
            Console.WriteLine ($"\nArchivo #{i} - Nombre (escriba 'salir para detener')");
            string nombre= Console.ReadLine().Trim();
            if(nombre.ToLower()=="salir"){
                Console.WriteLine (">> Proceso de descarga Cancelado!!");
                break;
            }
            Console.WriteLine ("Tamaño en MB: ");

            double tamanio=0;
            if(!double.TryParse(Console.ReadLine(), out tamanio) || tamanio <= 0){
                Console.WriteLine (">> TAmaño invalido. Archivo omitido");
                continue;
            }
            Console.WriteLine ($">> Descargando '{nombre}' ({tamanio} MB)... OK");
            archivosDescargados++;
            totalMB += tamanio;

            Console.WriteLine ("\n ========== RESUEMEN DE DESCARGA ==========");
            Console.WriteLine ($"Archivos Descargados: {archivosDescargados}");
            Console.WriteLine ($"Total Descargados: {totalMB}");
            Console.WriteLine ($"======================================");
        }

    }
}