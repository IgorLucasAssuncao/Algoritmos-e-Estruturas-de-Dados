/*using System;

namespace ListaA2
{
    class Site
    {
        string link;
        string nome;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public Site()
        {
            this.link = "";
            this.nome = "";
        }
        public Site(string link, string nome)
        {
            this.link = link;
            this.nome = nome;

        }
        public void imprimir(){
            Console.WriteLine("Nome: " + this.nome + " | Link: " + this.link);
        }
    }
    class Celula
    {

        private Site item;
        private Celula? proximo;
        private Celula? anterior;


        public Site Item
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

        public Celula(Site novo)
        {
            item = novo;
            anterior = null;
            proximo = null;
        }

        public Celula()
        {

            item = new Site();
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

        public void inserirFinal(Site novo)
        {

            Celula novaCelula;

            novaCelula = new Celula(novo);

            ultimo.Proximo = novaCelula;
            novaCelula.Anterior = ultimo;

            ultimo = novaCelula;

            tamanho++;

        }

        public Site removerFinal()
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
        public void inserir(Site novo, int posicao)
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

        public Site remover(int posicao)
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
        public int contarElemento(Site elemento)
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

        public void removerElemento(Site elemento)
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
            ListaDuplamenteEncadeada Sites = new ListaDuplamenteEncadeada();
            bool continuar = true;
            int option = 0;
            Console.WriteLine("Insira uma das opções abaixo:");
            while (continuar)
            {

             
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("1) Inserir um Site no início da lista");
                Console.WriteLine("2) Inserir um Site no final da lista");
                Console.WriteLine("3) Inserir um Site numa posição específica da lista");
                Console.WriteLine("4) Remover o primeiro Site da lista");
                Console.WriteLine("5) Remover o último Site da lista");
                Console.WriteLine("6) Remover um Site de uma posição específica da lista");
                Console.WriteLine("7) Mostrar o nome e o link de todos os sites da lista");
                Console.WriteLine("8) Encerrar o programa");

                Console.WriteLine("Insira a opção:");
                option = int.Parse(Console.ReadLine()??"" ?? "0");

                switch (option)
                {
                    case 1:
                        Console.Write("Nome do Site: ");
                        string nomeSiteInicio = Console.ReadLine()??"";
                        Console.Write("Link do Site: ");
                        string linkSiteInicio = Console.ReadLine()??"";
                        Site siteInicio = new Site(nomeSiteInicio, linkSiteInicio);
                        Sites.inserir(siteInicio,0);
                        break;

                    case 2:
                        Console.Write("Nome do Site: ");
                        string nomeSiteFinal = Console.ReadLine()??"";
                        Console.Write("Link do Site: ");
                        string linkSiteFinal = Console.ReadLine()??"";
                        Site siteFinal = new Site(nomeSiteFinal, linkSiteFinal);
                        Sites.inserirFinal(siteFinal);
                        break;

                    case 3:
                        Console.Write("Informe a posição de inserção: ");
                        int posicaoInsercao = Convert.ToInt32(Console.ReadLine()??"");
                        Console.Write("Nome do Site: ");
                        string nomeSiteInsercao = Console.ReadLine()??"";
                        Console.Write("Link do Site: ");
                        string linkSiteInsercao = Console.ReadLine()??"";
                        Site siteInsercao = new Site(nomeSiteInsercao, linkSiteInsercao);
                       Sites.inserir(siteInsercao, posicaoInsercao);
                        break;

                    case 4:
                      
                       Sites.remover(0);
                        break;

                    case 5:
                        
                        Console.WriteLine("Site removido: " + Sites.removerFinal().Nome);
                        break;

                    case 6:
                        Console.Write("Informe a posição de remoção: ");
                        int posicaoRemocao = int.Parse(Console.ReadLine()??"0");

                  
                            Console.WriteLine("Site removido: " + Sites.remover(posicaoRemocao).Nome);
                        
                        break;
                    case 7:

                        Console.WriteLine("Sites na lista:");
                        Sites.imprimir();
                        break;
                    case 8:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Escolha um número de 1 a 8.");
                        break;
                }
            }
        }
    }
}
*/