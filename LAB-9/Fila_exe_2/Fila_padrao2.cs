/*using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Queue<Impressao> filaImpressao = new Queue<Impressao>();

        int opcao = 0;
        while (opcao != 4) {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Inserir arquivo na fila de impressão");
            Console.WriteLine("2. Executar impressão");
            Console.WriteLine("3. Exibir fila de impressão");
            Console.WriteLine("4. Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    Console.WriteLine("Digite o nome do arquivo:");
                    string nomeArquivo = Console.ReadLine();

                    Console.WriteLine("Digite o número de páginas do arquivo:");
                    int numPaginas = int.Parse(Console.ReadLine());

                    Impressao impressao = new Impressao(nomeArquivo, numPaginas);
                    filaImpressao.Enqueue(impressao);

                    Console.WriteLine("Arquivo adicionado à fila de impressão.");
                    break;

                case 2:
                    if (filaImpressao.Count == 0) {
                        Console.WriteLine("Não há arquivos na fila de impressão.");
                    } else {
                        Impressao arquivoImpressao = filaImpressao.Dequeue();
                        Console.WriteLine("Arquivo " + arquivoImpressao.Nome + " enviado para impressão.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Arquivos na fila de impressão:");
                    foreach (Impressao arquivo in filaImpressao) {
                        Console.WriteLine(arquivo.Nome + " - " + arquivo.NumPaginas + " páginas");
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

class Impressao {
    public string Nome { get; set; }
    public int NumPaginas { get; set; }

    public Impressao(string nome, int numPaginas) {
        Nome = nome;
        NumPaginas = numPaginas;
    }
}
*/