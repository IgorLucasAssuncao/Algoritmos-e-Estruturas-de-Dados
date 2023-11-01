using System;

namespace ListaNativa1
{
    class ListaNativa1
    {
        public static void Main(string[] args)
        {
            List<double> Tempo = new List<double>();
            bool continuar = true;
            int option = 0;
            Console.WriteLine("Insira uma das opções abaixo:");
            while (continuar)
            {

                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("1) Inserir um tempo no início da lista");
                Console.WriteLine("2) Inserir um tempo no final da lista");
                Console.WriteLine("3) Inserir um tempo numa posição específica da lista");
                Console.WriteLine("4) Remover o primeiro tempo da lista");
                Console.WriteLine("5) Remover o último tempo da lista");
                Console.WriteLine("6) Remover um tempo de uma posição específica na lista");
                Console.WriteLine("7) Remover um tempo específico da lista");
                Console.WriteLine("8) Pesquisar quantas vezes um determinado tempo consta na lista");
                Console.WriteLine("9) Mostrar todos os tempos da lista");
                Console.WriteLine("10) Encerrar o programa");

                Console.WriteLine("Insira a opção:");
                option = int.Parse(Console.ReadLine() ?? "0");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Insira o tempo:");
                        double tempo = double.Parse(Console.ReadLine() ?? "0");
                        Tempo.Insert(0, tempo);
                        Console.WriteLine("Tempo inserido no início da lista!");
                        break;
                    case 2:
                        Console.WriteLine("Insira o tempo:");
                        double tempo2 = double.Parse(Console.ReadLine() ?? "0");
                        Tempo.Add(tempo2);
                        Console.WriteLine("Tempo inserido no final da lista!");
                        break;
                    case 3:
                        Console.WriteLine("Insira o tempo:");
                        double tempo3 = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine("Insira a posição:");
                        int posicao = int.Parse(Console.ReadLine() ?? "0");
                        Tempo.Insert(posicao, tempo3);
                        Console.WriteLine("Tempo inserido na posição " + posicao + " da lista!");
                        break;
                    case 4:
                        Tempo.RemoveAt(0);
                        Console.WriteLine("Tempo removido do início da lista!");
                        break;
                    case 5:
                        Tempo.RemoveAt(Tempo.Count - 1);
                        Console.WriteLine("Tempo removido do final da lista!");
                        break;
                    case 6:
                        Console.WriteLine("Insira a posição:");
                        int posicao2 = int.Parse(Console.ReadLine() ?? "0");
                        Tempo.RemoveAt(posicao2);
                        Console.WriteLine("Tempo removido da posição " + posicao2 + " da lista!");
                        break;
                    case 7:
                        Console.WriteLine("Insira o tempo:");
                        double tempo4 = double.Parse(Console.ReadLine() ?? "0");
                        Tempo.Remove(tempo4);
                        Console.WriteLine("Tempo removido da lista!");
                        break;
                    case 8:
                        Console.WriteLine("Insira o tempo:");
                        double tempo5 = double.Parse(Console.ReadLine() ?? "0");
                        int cont = 0;

                        for (int i = 0; i < Tempo.Count; i++)
                        {
                            if (Tempo[i] == tempo5)
                            {
                                cont++;
                            }
                        }
                        Console.WriteLine("O tempo " + tempo5 + " aparece " + cont + " vezes na lista!");
                        break;
                    case 9:
                        Console.WriteLine("Tempos da lista:");
                        for (int i = 0; i < Tempo.Count; i++)
                        {
                            Console.WriteLine(Tempo[i]);
                        }
                        break;
                    case 10:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            }
        }
    }
}