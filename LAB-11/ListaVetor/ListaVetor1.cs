/*using System;

namespace ListaVetor1
{
    class ListaLinear
    {

        private double[] lista;
        private int primeiro;
        private int ultimo;
        private int tamanho;

        public ListaLinear(int M)
        {

            lista = new double[M];
            tamanho = 0;
            primeiro = 0;
            ultimo = 0;
        }

        public Boolean listaVazia()
        {

            Boolean resp;

            if (primeiro == ultimo)
                resp = true;
            else
                resp = false;

            return resp;
        }

        public Boolean listaCheia()
        {

            Boolean resp;

            if (ultimo == lista.Length)
                // if (tamanho == lista.Length)
                resp = true;
            else
                resp = false;

            return resp;
        }

        public void inserir(double novo, int posicao)
        {

            if (!listaCheia())
            {
                if ((posicao >= 0) && (posicao <= tamanho))
                {
                    for (int i = ultimo; i > posicao; i--)
                        lista[i] = lista[i - 1];

                    lista[posicao] = novo;

                    ultimo++;
                    tamanho++;
                }
                else
                    throw new Exception("Não foi possível inserir o item na lista: posição informada é inválida!");
            }
            else
                throw new Exception("Não foi possível inserir o item na lista: a lista está cheia!");
        }

        public double remover(int posicao)
        {

            double removido;

            if (!listaVazia())
            {
                if ((posicao >= 0) && (posicao < tamanho))
                {

                    removido = lista[posicao];
                    tamanho--;

                    for (int i = posicao; i < tamanho; i++)
                    {
                        lista[i] = lista[i + 1];
                    }

                    ultimo--;

                    return removido;
                }
                else
                    throw new Exception("Não foi possível remover o item da lista: posição informada é inválida!");
            }
            else
                throw new Exception("Não foi possível remover o item da lista: a lista está vazia!");
        }
        public double remover(double removido){
            if (!listaVazia())
            {
                for (int i = 0; i < tamanho; i++)
                {
                    if (lista[i] == removido)
                    {
                        remover(i);
                        return removido;
                    }
                }
                throw new Exception("Não foi possível remover o item da lista: item não encontrado!");
            }
            else
                throw new Exception("Não foi possível remover o item da lista: a lista está vazia!");
        }
        public void inserirNoFinal(double novo)
        {
            if (!listaCheia())
            {
                lista[ultimo] = novo;
                ultimo++;
                tamanho++;
            }
            else
            {
                throw new Exception("Não foi possível inserir o item no final da lista: a lista está cheia!");
            }
        }
        public double removerDoInicio()
        {
            if (!listaVazia())
            {
                double removido = lista[primeiro];
                for (int i = primeiro; i < ultimo - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                ultimo--;
                tamanho--;
                return removido;
            }
            else
            {
                throw new Exception("Não foi possível remover o item do início da lista: a lista está vazia!");
            }
        }

        public double removerDoFinal()
        {
            if (!listaVazia())
            {
                double removido = lista[ultimo - 1];
                ultimo--;
                tamanho--;
                return removido;
            }
            else
            {
                throw new Exception("Não foi possível remover o item do final da lista: a lista está vazia!");
            }
        }
        public int contarElemento(double elemento)
        {
            int contador = 0;
            for (int i = primeiro; i < ultimo; i++)
            {
                if (lista[i] == elemento)
                {
                    contador++;
                }
            }
            return contador;
        }

        public void imprimir()
        {

            if (!listaVazia())
            {

                for (int i = primeiro; i < ultimo; i++)
                {
                    Console.WriteLine("Posição: " + i + ": ");
                    Console.WriteLine("" + lista[i]);
                }
            }
            else
                throw new Exception("Não foi possível imprimir o conteúdo da lista: a lista está vazia!");
        }

    }
    class ListaVetor1
    {
        public static void Main()
        {
            ListaLinear Tempo = new ListaLinear(100);
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
                        Tempo.inserir(tempo, 0);
                        Console.WriteLine("Tempo inserido no início da lista!");
                        break;
                    case 2:
                        Console.WriteLine("Insira o tempo:");
                        double tempo2 = double.Parse(Console.ReadLine() ?? "0");
                        Tempo.inserirNoFinal(tempo2);
                        Console.WriteLine("Tempo inserido no final da lista!");
                        break;
                    case 3:
                        Console.WriteLine("Insira o tempo:");
                        double tempo3 = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine("Insira a posição:");
                        int posicao = int.Parse(Console.ReadLine() ?? "0");
                        Tempo.inserir(tempo3, posicao);
                        Console.WriteLine("Tempo inserido na posição " + posicao + " da lista!");
                        break;
                    case 4:
                        Tempo.removerDoInicio();
                        Console.WriteLine("Tempo removido do início da lista!");
                        break;
                    case 5:
                        Tempo.removerDoFinal();
                        Console.WriteLine("Tempo removido do final da lista!");
                        break;
                    case 6:
                        Console.WriteLine("Insira a posição:");
                        int posicao2 = int.Parse(Console.ReadLine() ?? "0");
                        Tempo.remover(posicao2);
                        Console.WriteLine("Tempo removido da posição " + posicao2 + " da lista!");
                        break;
                    case 7:
                        Console.WriteLine("Insira o tempo:");
                        double tempo4 = double.Parse(Console.ReadLine() ?? "0");
                        Tempo.remover(tempo4);
                        Console.WriteLine("Tempo removido da lista!");
                        break;
                    case 8:
                        Console.WriteLine("Insira o tempo:");
                        double tempo5 = double.Parse(Console.ReadLine() ?? "0");
                        int cont = Tempo.contarElemento(tempo5);
                        Console.WriteLine("O tempo " + tempo5 + " aparece " + cont + " vezes na lista!");
                        break;
                    case 9:
                        Console.WriteLine("Tempos da lista:");
                        Tempo.imprimir();
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
*/