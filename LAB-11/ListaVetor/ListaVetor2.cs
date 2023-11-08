/*using System;

namespace ListaVetor2
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
    }
    class ListaLinear
    {

        private Site[] lista;
        private int primeiro;
        private int ultimo;
        private int tamanho;

        public ListaLinear(int M)
        {

            lista = new Site[M];
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

        public void inserir(Site novo, int posicao)
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

        public Site remover(int posicao)
        {

            Site removido;

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
        public Site remover(Site removido)
        {
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
        public void inserirNoFinal(Site novo)
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
        public Site removerDoInicio()
        {
            if (!listaVazia())
            {
                Site removido = lista[primeiro];
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

        public Site removerDoFinal()
        {
            if (!listaVazia())
            {
                Site removido = lista[ultimo - 1];
                ultimo--;
                tamanho--;
                return removido;
            }
            else
            {
                throw new Exception("Não foi possível remover o item do final da lista: a lista está vazia!");
            }
        }
        public int contarElemento(Site elemento)
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
                    Console.WriteLine("" + lista[i].Nome + " | " + lista[i].Link);
                }
            }
            else
                throw new Exception("Não foi possível imprimir o conteúdo da lista: a lista está vazia!");
        }

    }
    class ListaVetor2
    {
        public static void Main(string[] args)
        {
            ListaLinear Sites = new ListaLinear(100);
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
                option = int.Parse(Console.ReadLine() ?? "" ?? "0");

                switch (option)
                {
                    case 1:
                        Console.Write("Nome do Site: ");
                        string nomeSiteInicio = Console.ReadLine() ?? "";
                        Console.Write("Link do Site: ");
                        string linkSiteInicio = Console.ReadLine() ?? "";
                        Site siteInicio = new Site(nomeSiteInicio, linkSiteInicio);
                        Sites.inserir(siteInicio, 0);
                        break;

                    case 2:
                        Console.Write("Nome do Site: ");
                        string nomeSiteFinal = Console.ReadLine() ?? "";
                        Console.Write("Link do Site: ");
                        string linkSiteFinal = Console.ReadLine() ?? "";
                        Site siteFinal = new Site(nomeSiteFinal, linkSiteFinal);
                        Sites.inserirNoFinal(siteFinal);
                        break;

                    case 3:
                        Console.Write("Informe a posição de inserção: ");
                        int posicaoInsercao = Convert.ToInt32(Console.ReadLine() ?? "");
                        Console.Write("Nome do Site: ");
                        string nomeSiteInsercao = Console.ReadLine() ?? "";
                        Console.Write("Link do Site: ");
                        string linkSiteInsercao = Console.ReadLine() ?? "";
                        Site siteInsercao = new Site(nomeSiteInsercao, linkSiteInsercao);
                        Sites.inserir(siteInsercao, posicaoInsercao);
                        break;
                    case 4:
                        Sites.removerDoInicio();
                        break;
                    case 5:
                        Console.WriteLine("Site removido: " + Sites.removerDoFinal().Nome);
                      break;
                    case 6:
                        Console.Write("Informe a posição de remoção: ");
                        int posicaoRemocao = int.Parse(Console.ReadLine() ?? "0");
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