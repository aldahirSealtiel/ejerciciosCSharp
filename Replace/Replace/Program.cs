using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] whiteSpace = { ' ', '\n', '\t' };
            string s = "this is a\nstring";
            Console.WriteLine("before: " + s);

            Console.Write("after:");
            while (true)
            {
                int offset = s.LastIndexOfAny(whiteSpace);
                if (offset == -1)
                {
                    break;
                }
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);

                s = String.Concat(before, after);
            }
            Console.WriteLine(s);
            Console.WriteLine("Presiona una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
