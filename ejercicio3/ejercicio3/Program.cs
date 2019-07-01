using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = String.Format("{0} times {1} equals {2}", 2, 5, 2*5);
            Console.WriteLine(myString);
            Console.WriteLine("Presiona una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
