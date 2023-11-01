/*using System;

namespace Lab_10
{
    class Principal
    {
        public static void Main(string[] args)
        {
            string entrada = "";
            int opcao = 0;
            bool control = true;
            FilaFlex fila = new FilaFlex();

            for (int i = 1; i < 11; i++)
            {
                fila.enfileirar( new Aviao("Avião " + i));
            }

            while (control)
            {
                Console.WriteLine("Bem vindo ao gerenciador da fila de aviões!");
                Console.WriteLine("1.Listar a quantidade de aviões que estão aguardando na fila de decolagem");
                Console.WriteLine("2.Autorizar a decolagem do primeiro avião da fila de decolagem (isto é, retirar da fila de decolagem)");
                Console.WriteLine("3.Adicionar um avião na fila de decolagem");
                Console.WriteLine("4.Listar todos os aviões que estão na fila de decolagem");
                Console.WriteLine("5.Exibir o primeiro avião da fila de decolagem");
                Console.WriteLine("6.Sair");
                Console.WriteLine("Digite a opção desejada:");

                opcao = int.Parse(Console.ReadLine() ?? "0");

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("A quantidade de aviões na fila é: " + fila.TamanhoFila());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("O avião " + fila.desenfileirar() + " decolou!");
                        Console.WriteLine(); break;
                    case 3:

                        Console.WriteLine("Digite o nome do avião:");
                        entrada = Console.ReadLine()??"";
                        fila.enfileirar(new Aviao(entrada));
                        Console.WriteLine("O avião " + entrada + " foi adicionado a fila!");
                        Console.WriteLine();
                        break;

                    case 4:
                     fila.imprimir();
                        break;
                    case 5:

                        Console.WriteLine("O primeiro avião da fila é: ");
                        fila.PrimeiroNaFila().imprimir();
                        Console.WriteLine();
                        break;
                    case 6:
                        control = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
*/
