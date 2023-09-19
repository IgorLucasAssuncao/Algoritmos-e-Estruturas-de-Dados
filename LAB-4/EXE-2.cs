/*using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EXE_2
{
    class EXE_2
    {
        public static void Main()
        {
            int m, n;
            Console.WriteLine("Insira o valor de m:");
            m = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Insira o valor de n:");
            n = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"A soma é: {Calcula(m, n)}");

        }

        public static int Calcula(int m, int n)
        {
            int resultado;

            if (m > n)
            {
                return 0;
            }
            else
            {
                resultado = m + Calcula(++m, n);
            }
            return resultado;
        }
    }
}*/