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

                                Selecao(array, n);

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
                                SelecaoDecrescente(array, n);
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

                    case 'b':
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

                                Insercao(array, n);

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
                                InsercaoDecrescente(array, n);
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

                    case 'c':
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

                                Bublesort(array, n);

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
                                BublesortDecrescente(array, n);
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
                        Console.WriteLine("Programa encerrado!");
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
            Console.WriteLine("a) Algoritmo Seleção");
            Console.WriteLine("b) Algoritmo da Bolha (Bubblesort)");
            Console.WriteLine("c) Algoritmo de Inserção");
            Console.WriteLine("d) Encerrar o programa");
        }

        static void MenuOpcao()
        {
            Console.WriteLine("Deseja ordenar de forma crescente?");
            Console.WriteLine("Insira uma das opções abaixo:");
            Console.WriteLine("a) Sim");
            Console.WriteLine("b) Não");
        }
        static void Bublesort(int[] array, int n)
        {
            for (int i = (n - 1); i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void BublesortDecrescente(int[] array, int n)
        {
            for (int i = (n - 1); i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void Insercao(int[] array, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int tmp = array[i];
                int j = i - 1;

                while ((j >= 0) && (array[j] > tmp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = tmp;
            }
        }
        static void InsercaoDecrescente(int[] array, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int tmp = array[i];
                int j = i - 1;

                while ((j >= 0) && (array[j] < tmp))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = tmp;
            }
        }
        static void Selecao(int[] array, int n)
        {
            for (int i = 0; i < (n - 1); i++)
            {
                int menor = i;
                for (int j = (i + 1); j < n; j++)
                {
                    if (array[menor] > array[j])
                    {
                        menor = j;
                    }
                }
                int temp = array[i];
                array[i] = array[menor];
                array[menor] = temp;
            }
        }
        static void SelecaoDecrescente(int[] array, int n)
        {
            for (int i = 0; i < (n - 1); i++)
            {
                int maior = i;
                for (int j = (i + 1); j < n; j++)
                {
                    if (array[maior] < array[j])
                    {
                        maior = j;
                    }
                }
                int temp = array[i];
                array[i] = array[maior];
                array[maior] = temp;
            }
        }
    }
}