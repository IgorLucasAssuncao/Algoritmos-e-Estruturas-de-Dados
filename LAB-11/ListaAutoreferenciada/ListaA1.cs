using System;

namespace ListaA1
{
    class Ponteiro
    {

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Ponteiro(double valor)
        {
            this.valor = valor;
        }

        public Ponteiro()
        {
            valor = 0;
        }

        public void imprimir()
        {
            Console.WriteLine("Valor -> " + valor);
        }
    }

    class Celula
    {

        private Ponteiro item;
        private Celula? proximo;
        private Celula? anterior;


        public Ponteiro Item
        {
            get { return item; }
            set { item = value; }
        }


        public Celula? Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public Celula? Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Celula(Ponteiro novo)
        {
            item = novo;
            anterior = null;
            proximo = null;
        }

        public Celula()
        {

            item = new Ponteiro();
            anterior = null;
            proximo = null;
        }
    }

    class ListaDuplamenteEncadeada
    {

        private Celula primeiro;
        private Celula ultimo;
        private int tamanho;

        public ListaDuplamenteEncadeada()
        {

            Celula sentinela;

            sentinela = new Celula();

            primeiro = sentinela;
            ultimo = sentinela;

            tamanho = 0;
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

        public void inserirFinal(Ponteiro novo)
        {

            Celula novaCelula;

            novaCelula = new Celula(novo);

            ultimo.Proximo = novaCelula;
            novaCelula.Anterior = ultimo;

            ultimo = novaCelula;

            tamanho++;

        }

        public Ponteiro removerFinal()
        {

            Celula removida, penultima;

            if (!listaVazia())
            {

                removida = ultimo;

                penultima = ultimo.Anterior;
                penultima.Proximo = null;
                removida.Anterior = null;

                ultimo = penultima;

                tamanho--;

                return (removida.Item);
            }
            else
                throw new Exception("Não foi possível remover o último item da lista: a lista está vazia!");
        }

        public void imprimir()
        {

            Celula aux;

            if (!listaVazia())
            {
                Console.WriteLine("Conteúdo da lista:");
                aux = primeiro.Proximo;
                while (aux != null)
                {
                    aux.Item.imprimir();
                    aux = aux.Proximo;
                }
            }
            else
                throw new Exception("Não foi possível imprimir o conteúdo da lista: a lista está vazia!");
        }
        public void inserir(Ponteiro novo, int posicao)
        {

            Celula anterior, novaCelula, proximaCelula;

            if ((posicao >= 0) && (posicao <= tamanho))
            {
                anterior = primeiro;
                for (int i = 0; i < posicao; i++)
                    anterior = anterior.Proximo;

                novaCelula = new Celula(novo);

                proximaCelula = anterior.Proximo;

                anterior.Proximo = novaCelula;
                novaCelula.Proximo = proximaCelula;

                if (posicao == tamanho)  // a inserção ocorreu na última posição da lista
                    ultimo = novaCelula;

                tamanho++;

            }
            else
                throw new Exception("Não foi possível inserir o item na lista: a posição informada é inválida!");
        }

        public Ponteiro remover(int posicao)
        {

            Celula anterior, celulaRemovida, proximaCelula;

            if (!listaVazia())
            {
                if ((posicao >= 0) && (posicao < tamanho))
                {
                    anterior = primeiro;
                    for (int i = 0; i < posicao; i++)
                        anterior = anterior.Proximo;

                    celulaRemovida = anterior.Proximo;

                    proximaCelula = celulaRemovida.Proximo;

                    anterior.Proximo = proximaCelula;
                    celulaRemovida.Proximo = null;

                    if (celulaRemovida == ultimo)
                        ultimo = anterior;

                    tamanho--;

                    return (celulaRemovida.Item);
                }
                else
                    throw new Exception("Não foi possível remover o item da lista: a posição informada é inválida!");
            }
            else
                throw new Exception("Não foi possível remover o item da lista: a lista está vazia!");
        }
        public int contarElemento(Ponteiro elemento)
        {
            int contador = 0;
            Celula atual = primeiro.Proximo;

            while (atual != null)
            {
                if (atual.Item.Equals(elemento))
                {
                    contador++;
                }
                atual = atual.Proximo;
            }

            return contador;
        }

        public void removerElemento(Ponteiro elemento)
        {
            Celula anterior = primeiro;
            Celula atual = primeiro.Proximo;

            while (atual != null)
            {
                if (atual.Item.Equals(elemento))
                {
                    Celula proximaCelula = atual.Proximo;
                    anterior.Proximo = proximaCelula;

                    if (atual == ultimo)
                    {
                        ultimo = anterior;
                    }

                    atual.Proximo = null;
                    tamanho--;
                    return; // Elemento encontrado e removido
                }

                anterior = atual;
                atual = atual.Proximo;
            }

            // Elemento não encontrado
            throw new Exception("Não foi possível remover o elemento da lista: elemento não encontrado!");
        }

    }

    class ListaA1
    {
        public static void Main(String[] args)
        {
            ListaDuplamenteEncadeada Tempo = new ListaDuplamenteEncadeada();

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
                        Tempo.inserir(new Ponteiro(tempo), 0);
                        Console.WriteLine("Tempo inserido no início da lista!");
                        break;
                    case 2:
                        Console.WriteLine("Insira o tempo:");
                        double tempo2 = double.Parse(Console.ReadLine() ?? "0");
                        Tempo.inserirFinal(new Ponteiro(tempo2));
                        Console.WriteLine("Tempo inserido no final da lista!");
                        break;
                    case 3:
                        Console.WriteLine("Insira o tempo:");
                        double tempo3 = double.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine("Insira a posição:");
                        int posicao = int.Parse(Console.ReadLine() ?? "0");
                        Tempo.inserir(new Ponteiro(tempo3), posicao);
                        Console.WriteLine("Tempo inserido na posição " + posicao + " da lista!");
                        break;
                    case 4:
                        Tempo.remover(0);
                        Console.WriteLine("Tempo removido do início da lista!");
                        break;
                    case 5:
                        Tempo.removerFinal();
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
                        Tempo.removerElemento(new Ponteiro(tempo4));
                        Console.WriteLine("Tempo removido da lista!");
                        break;
                    case 8:
                        Console.WriteLine("Insira o tempo:");
                        double tempo5 = double.Parse(Console.ReadLine() ?? "0");
                        int cont = Tempo.contarElemento(new Ponteiro(tempo5));
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