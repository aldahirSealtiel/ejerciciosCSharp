using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a double number");
                string numberInput = Console.ReadLine();
                if (numberInput.Length == 0)
                {
                    break;
                }
                double number = Double.Parse(numberInput);
                Console.WriteLine("Enter the format specifiers"
                                  + " separated by a blank "
                                  + "(Example: C E F1 N0 0000000.00000)"
                                 );
                char[] separator = { ' ' };
                string formatString = Console.ReadLine();
                string[] formats = formatString.Split(separator);
                foreach (string s in formats)
                {
                    if (s.Length != 0)
                    {
                        string formatCommand = "{0:" + s + "}";
                        Console.Write(
                                        "The format specifier {0} results in ", formatCommand);
                        try
                        {
                            Console.WriteLine(formatCommand, number);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("<illegal control>");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Press Enter to terminate... ");
            Console.ReadKey();
        }
    }
}
