/*using System;

namespace EXE_4
{
    class EXE_4
    {
        public static void Main()
        {
            long x, y;

            Console.WriteLine("Insira o valor de x:");
            x = long.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Insira o valor de y:");
            y = long.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"O MDC de {x} e {y} é: {MDC(x, y)}");


        }
        public static long MDC(long x, long y)
        {
            if (x > y)
            {
                return MDC(x - y, y);
            }
            else if (x == y)
            {
                return x;
            }
            else
            {
                return MDC(y, x);
            }


        }
    }
}*/