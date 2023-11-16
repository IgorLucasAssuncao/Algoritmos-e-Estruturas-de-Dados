using System;

namespace Ordena1
{
    class OrdenaMain1
    {
        public static void Main(String[] args)
        {
            char option = '0';
            bool continuar = true;

            Console.WriteLine("Bem-vindo ao programa de ordenação de vetores!");

            while (continuar)
            {
                Menu();

                option = char.Parse(Console.ReadLine() ?? "0");

                switch (option)
                {
                    case 'a':
                        try
                        {
                            Random rd = new Random();
                            MenuOpcao();
                            char option2 = char.Parse(Console.ReadLine() ?? "0");
                            if (option2 == 'a')
                            {
                                Console.WriteLine("Insira o tamanho do vetor:");
                                int n = int.Parse(Console.ReadLine() ?? "0");
                                int[] array = new int[n];
                                Console.WriteLine("Insira os elementos do vetor:");
                                for (int i = 0; i < n; i++)
                                {
                                    array[i] = rd.Next(0, 101);
                                }

                                quicksort(array, 0, array.Length-1);

                                Console.WriteLine("Vetor ordenado:");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine(array[i]);
                                }
                            }
                            else if (option2 == 'b')
                            {
                                Console.WriteLine("Insira o tamanho do vetor:");
                                int n = int.Parse(Console.ReadLine() ?? "0");
                                int[] array = new int[n];
                                Console.WriteLine("Insira os elementos do vetor:");
                                for (int i = 0; i < n; i++)
                                {
                                    array[i] = rd.Next(0, 101);
                                }
                                quicksortDecrescente(array, 0, array.Length-1);
                                Console.WriteLine("Vetor ordenado:");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine(array[i]);
                                }
                            }
                            else
                            {
                                throw new Exception("Opção inválida!");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro: " + e.Message);
                        }
                        break;
                    case 'd':
                        Console.WriteLine("Encerrando o programa...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("Insira uma das opções abaixo:");
            Console.WriteLine("a) Algoritmo Quicsksort:");
            Console.WriteLine("d) Encerrar o programa");
        }

        static void MenuOpcao()
        {
            Console.WriteLine("Deseja ordenar de forma crescente?");
            Console.WriteLine("Insira uma das opções abaixo:");
            Console.WriteLine("a) Sim");
            Console.WriteLine("b) Não");
        }
        private static void quicksort(int[] array, int esq, int dir)
        {
            int part;
            if (esq < dir)
            {
                part = particao(array, esq, dir/2);
             quicksort(array, esq, part - 1);
                quicksort(array, part + 1, dir);
            }
        }

        private static int particao(int[] array, int inicio, int fim)
        {
            int pivot = array[fim];
            int part = inicio - 1;
            for (int i = inicio; i < fim; i++)
            {
                if (array[i] < pivot)
                {
                    part++;
                    swap(array, part, i);
                }
            
            }
                part++;
                swap(array, part, fim);
                return (part);
        }
             private static void swap(int[] array, int i, int j)
            {

                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            private static void quicksortDecrescente(int[] array, int esq, int dir)
        {
            int part;
            if (esq < dir)
            {
                part = particaoDecrescente(array, esq, dir);
                quicksortDecrescente(array, esq, part - 1);
                quicksortDecrescente(array, part + 1, dir);
            }
        }

        private static int particaoDecrescente(int[] array, int inicio, int fim)
        {
            int pivot = array[fim];
            int part = inicio - 1;
            for (int i = inicio; i < fim; i++)
            {
                if (array[i] > pivot)
                {
                    part++;
                    swap(array, part, i);
                }
            
            }
                part++;
                swap(array, part, fim);
                return (part);
        }
    }
}