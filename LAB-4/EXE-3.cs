/*using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EXE_3
{
    class EXE_3
    {
        public static void Main()
        {
            int x;
            Console.WriteLine("Insira o número que deseja tranformar em binário:");
            x = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"{x} em binário é: {InverteString(Binary(x))}");
        }
        public static string Binary(int x)
        {
            string resultado;
            if (x == 0)
            {
                return "0";
            }
            else if (x == 1)
            {
                return "1";
            }
            else
            {
                resultado = "" + (x % 2) + Binary(x / 2);
            }
            return resultado;
        }
        public static string InverteString(string text)
        {
            string saida = "";
            for (int x = text.Length - 1; x >= 0; x--)
            {
                saida += text[x];
            }
            return saida;
        }
    }
}*/