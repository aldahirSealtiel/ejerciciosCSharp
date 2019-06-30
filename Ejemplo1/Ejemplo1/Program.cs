using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //nombres de prueba para el padeo
            List<string> nombres = new List<string> { "aldahir  Sealtiel",
                                                      "   sealtiel",
                                                      "  Daniel   "
                                                        };
            //escritura en consola de los nombres sin formato y padeo
            Console.WriteLine("Nombres sin formato: ");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine();
            //lista de strings donde se almacenaran los nombres con formato
            List<string> nombresAlineados = new List<string>();
            //Se quitan los espacios 
            for(int i = 0; i < nombres.Count; i++)
            {
                string nombreCortado = nombres[i].Trim(); //quita los espacios de una cadena del principio y fin de dicha cadena
                nombresAlineados.Add(nombreCortado);
            }
            //Se encontrara la longitud maxima para normalizar el numero de caracteres que contendran los nombres
            //si la longitud del nombre sin el padeo es menor que la longitud maxima se llenara con espacios
            int longitudMaxima = 0;
            foreach (string nombre in nombresAlineados)
            {
                if (nombre.Length > longitudMaxima)
                {
                    longitudMaxima = nombre.Length;
                }
            }
            //Se realiza el padeo de los nombres contenidos en la lista de los nombres sin espacios
            for (int i = 0; i < nombresAlineados.Count; i++)
            {
                nombresAlineados[i] = nombresAlineados[i].PadRight(longitudMaxima + 1);
            }
            //Impresion de los nombres
            Console.WriteLine("Nombres sin espacios y padeados:");
            foreach (string nombre in nombresAlineados)
            {
                Console.WriteLine("'"+nombre+"'");
            }
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
