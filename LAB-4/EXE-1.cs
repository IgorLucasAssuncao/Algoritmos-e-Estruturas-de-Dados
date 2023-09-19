/*using System;

namespace EXE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Insira o valor de a: ");
            x = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Insira o valor de n: ");
            y = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"{x} elevado a {y} é igual a {Multiplicar(x, y)}");
        }
        public static int Multiplicar(int x, int y)
        {
            int resultado = 0;
            if (y == 0)
            {
                return 1;
            }
            else
            {
                resultado = x * Multiplicar(x, --y);
            }
            return resultado;
        }
    }
}
*/