using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi djeljivi sa 3:");
            for (int i=0; i<100; ++i)
            {
                if (i % 3 == 0)
                    Console.Write(i+" ");
            }
            Console.WriteLine("Gotovo!");

            for (int i=0; i < args.Length; ++i)
            {
                try
                {
                    double a = double.Parse(args[i][0].ToString());
                    char op = char.Parse(args[i][1].ToString());
                    double b = double.Parse(args[i][2].ToString());

                    switch (op)
                    {
                        case '+':
                            Console.WriteLine("{0}" + op + "{1}={2}", a, b, a + b);
                            break;
                        case '-':
                            Console.WriteLine("{0}" + op + "{1}={2}", a, b, a - b);
                            break;
                        case '*':
                            Console.WriteLine("{0}" + op + "{1}={2}", a, b, a * b);
                            break;
                        case '/':
                            Console.WriteLine("{0}" + op + "{1}={2}", a, b, a / b);
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Greska u formatu unosa: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Generalna greska: " + e.Message);
                }
            }
        }
    }
}
