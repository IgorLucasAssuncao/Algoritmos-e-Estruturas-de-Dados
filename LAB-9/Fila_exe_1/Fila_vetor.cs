/*using System;


namespace FilaVetor
{
    public class Fila
    {

        private string[] fila;
        private int frente;
        private int tras;
        private int tamanho;

        public Fila(int tamanho)
        {

            fila = new string[tamanho];
            frente = 0;
            tras = 0;
            this.tamanho = tamanho;
        }

        public Boolean filaVazia()
        {

            Boolean resp;

            if (frente == tras)
                resp = true;
            else
                resp = false;

            return resp;
        }

        public Boolean filaCheia()
        {

            Boolean resp;

            if (((tras + 1) % tamanho) == (frente % tamanho))
                resp = true;
            else
                resp = false;

            return resp;
        }

        public void enfileirar(string novo)
        {

            int posicao;

            if (!filaCheia())
            {
                posicao = tras % tamanho;
                fila[posicao] = novo;
                tras++;
            }
            else
                throw new Exception("Não foi possível enfileirar o novo elemento: a fila está cheia!");
        }

        public string desenfileirar()
        {

            string desenfileirado;
            int posicao;

            if (!filaVazia())
            {
                posicao = frente % tamanho;
                desenfileirado = fila[posicao];
                frente++;
                return desenfileirado;
            }
            else
                throw new Exception("Não foi possível desenfileirar nenhum elemento: a fila está vazia!");
        }

        public void imprimir()
        {

            int posicao;
            if (!filaVazia())
            {
                Console.WriteLine("Conteúdo da fila:");
                for (int i = frente; i < tras; i++)
                {
                    posicao = i % tamanho;
                    Console.WriteLine("Posição: " + posicao + ": ");
                    Console.WriteLine(" " + fila[posicao]);
                }
            }
            else
                throw new Exception("Não foi possível mostrar o conteúdo da fila: a fila está vazia!");
        }

        public int QuantidadeItensNaFila()
        {
            if (tras >= frente)
            {
                return tras - frente;
            }
            else
            {
                return tamanho - (frente - tras);
            }
        }
        public void imprimirPrimeiro()
        {
            if (!filaVazia())
            {
                Console.WriteLine(fila[frente]);
            }
            else
            {
                throw new Exception("Fila vazia");

            }
        }
    }

    class FilaVet
    {
        public static void Main()
        {
            string entrada = "";
            int opcao = 0;
            bool control = true;
            Fila fila = new Fila(10);

            for (int i = 1; i < 11; i++)
            {
                fila.enfileirar("Avião " + i);
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
                        Console.WriteLine("A quantidade de aviões na fila é: " + fila.QuantidadeItensNaFila());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("O avião " + fila.desenfileirar() + " decolou!");
                        Console.WriteLine(); break;
                    case 3:

                        Console.WriteLine("Digite o nome do avião:");
                        entrada = Console.ReadLine();
                        fila.enfileirar(entrada);
                        Console.WriteLine("O avião " + entrada + " foi adicionado a fila!");
                        Console.WriteLine();
                        break;

                    case 4:
                        fila.imprimir();
                        Console.WriteLine();
                        break;
                    case 5:

                        Console.WriteLine("O primeiro avião da fila é: ");
                        fila.imprimirPrimeiro();
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