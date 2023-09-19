/*using System;
namespace EXE_3
{
    class Exe_3
    {
        public static void Main()
        {
            int[] vetor = new int[10];
            int procura = 0;
            Console.WriteLine("Insira 10 valores para o vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.WriteLine("Insira o valor que deseja procurar: ");
            procura = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("O valor foi encontrado na posição: " + Procurar(procura, vetor, vetor.Length - 1));
        }

        public static int Procurar(int num, int[] vetor, int posicao)
        {
            if (vetor[posicao] == num)
            {
                return posicao;
            }
            else if (posicao == 0)
            {
                return -1;
            }
            else
            {
                return Procurar(num, vetor, posicao - 1);
            }
        }


    }
}*/