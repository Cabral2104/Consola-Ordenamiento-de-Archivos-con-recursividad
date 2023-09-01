 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Consola_Ordenamiento_de_Archivos_con_recursividad
{
    internal class Program
    {
        static void ListarArchivosRecursivo(string directorio)
        {
            try
            {
                string[] archivos = Directory.GetFiles(directorio).OrderBy(fileName => fileName).ToArray();

                foreach (string archivo in archivos)
                {
                    Console.WriteLine("Archivo: " + Path.GetFileName(archivo) + " - Extensión: " + Path.GetExtension(archivo));
                }

                string[] subdirectorios = Directory.GetDirectories(directorio);
                foreach (string subdirectorio in subdirectorios)
                {
                    ListarArchivosRecursivo(subdirectorio);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            string directorioRaiz = @"C:\Users\Carlos Emilio Cabral\Documents\Carlos Emilio Cabral Valdez Informática 1"; // Cambia esta ruta al directorio que desees explorar
            Console.WriteLine("Listado de archivos y extensiones:");
            ListarArchivosRecursivo(directorioRaiz);
            Console.ReadKey();
        }
    }
}
 