using System;
using System.Text.RegularExpressions;

namespace regulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            
            Console.WriteLine("************************************************************");
            Console.WriteLine("* Bienvenido a programa de expresiones regulares con REGEX *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* 1. Validar URLs                                          *");
            Console.WriteLine("* 2. Validar numeros telefonicos                           *");
            Console.WriteLine("* 3. Salir                                                 *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Introduzca su opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca una cadena: ");
            string cadena = Console.ReadLine();
            switch (opcion)
            {
                case 1:
                    url(cadena);
                    break;
                
                case 2:
                    numero(cadena);
                    break;
                
                default:
                    Console.WriteLine("Opcion no valida porfavor intente de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
        public static void url(string cadena)
        {
            string pattern = @"^(https?:\/\/(?:www\.|(?!www))[^\s\.]+\.[^\s]{2,}|www\.[^\s]+\.[^\s]{2,})$";
            Console.Write($"La expresion regular a validar es: {pattern}");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("{0} {1} una cadena valida.",
                              cadena,
                              Regex.IsMatch(cadena, pattern, RegexOptions.IgnoreCase)
                                            ? "es" : "no es", TimeSpan.FromMilliseconds(500));
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("Tiempo excedido {0} segundos coincidentes {1}",
                              e.MatchTimeout, e.Input);
            }
        }
        public static void numero(string cadena)
        {
            string pattern = "([+52]|)((\\s?[0-9]{3}(-?|\\s?)){2}[0-9]{4}|(\\s?[0-9]{2}(-?|\\s?)){4}[0-9]{2})";
            Console.Write($"La expresion regular a validar es: {pattern}");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("{0} {1} una cadena valida.",
                              cadena,
                              Regex.IsMatch(cadena, pattern, RegexOptions.IgnoreCase)
                                            ? "es" : "no es", TimeSpan.FromMilliseconds(500));
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("Tiempo excedido {0} segundos coincidentes {1}",
                              e.MatchTimeout, e.Input);
            }
        }
    }
}
