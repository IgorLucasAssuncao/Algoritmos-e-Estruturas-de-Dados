using System;
using System.Collections.Generic;
namespace Lab_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaFlex filaImpressao = new FilaFlex();

            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Inserir arquivo na fila de impressão");
                Console.WriteLine("2. Executar impressão");
                Console.WriteLine("3. Exibir fila de impressão");
                Console.WriteLine("4. Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do arquivo:");
                        string nomeArquivo = Console.ReadLine();

                        Console.WriteLine("Digite o número de páginas do arquivo:");
                        int numPaginas = int.Parse(Console.ReadLine());

                        Impressao impressao = new Impressao(nomeArquivo, numPaginas);
                        filaImpressao.enfileirar(impressao);

                        Console.WriteLine("Arquivo adicionado à fila de impressão.");
                        break;

                    case 2:
                        if (filaImpressao.filaVazia())
                        {
                            Console.WriteLine("Não há arquivos na fila de impressão.");
                        }
                        else
                        {
                            Impressao arquivoImpressao = filaImpressao.desenfileirar();
                            Console.WriteLine("Arquivo " + arquivoImpressao.Nome + " enviado para impressão.");
                        }
                        break;

                    case 3:
                    try{
                        Console.WriteLine("Arquivos na fila de impressão:");
                       filaImpressao.imprimir();
                    }catch(Exception e){
                      Console.WriteLine(""+e.Message);
                    }
                        break;

                    case 4:
                        Console.WriteLine("Encerrando programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}