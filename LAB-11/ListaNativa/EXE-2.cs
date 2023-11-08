/*using System;

namespace ListaNativa2
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
    class ListaNativa2
    {
        public static void Main()
        {

            List<Site> Sites = new List<Site>();
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
                        Sites.Insert(0, siteInicio);
                        break;

                    case 2:
                        Console.Write("Nome do Site: ");
                        string nomeSiteFinal = Console.ReadLine()??"";
                        Console.Write("Link do Site: ");
                        string linkSiteFinal = Console.ReadLine()??"";
                        Site siteFinal = new Site(nomeSiteFinal, linkSiteFinal);
                        Sites.Add(siteFinal);
                        break;

                    case 3:
                        Console.Write("Informe a posição de inserção: ");
                        int posicaoInsercao = Convert.ToInt32(Console.ReadLine()??"");
                        Console.Write("Nome do Site: ");
                        string nomeSiteInsercao = Console.ReadLine()??"";
                        Console.Write("Link do Site: ");
                        string linkSiteInsercao = Console.ReadLine()??"";
                        Site siteInsercao = new Site(nomeSiteInsercao, linkSiteInsercao);
                        if (posicaoInsercao >= 0 && posicaoInsercao <= Sites.Count)
                        {
                            Sites.Insert(posicaoInsercao, siteInsercao);
                        }
                        else
                        {
                            Console.WriteLine("Posição inválida. O site não foi inserido.");
                        }
                        break;

                    case 4:
                        if (Sites.Count > 0)
                        {
                            Site siteRemovido = Sites[0];
                            Sites.RemoveAt(0);
                            Console.WriteLine("Site removido: " + siteRemovido.Nome);
                        }
                        else
                        {
                            Console.WriteLine("A lista de sites está vazia. Não é possível remover.");
                        }
                        break;

                    case 5:
                        if (Sites.Count > 0)
                        {
                            int indiceUltimo = Sites.Count - 1;
                            Site siteRemovido = Sites[indiceUltimo];
                            Sites.RemoveAt(indiceUltimo);
                            Console.WriteLine("Site removido: " + siteRemovido.Nome);
                        }
                        else
                        {
                            Console.WriteLine("A lista de sites está vazia. Não é possível remover.");
                        }
                        break;

                    case 6:
                        Console.Write("Informe a posição de remoção: ");
                        int posicaoRemocao = int.Parse(Console.ReadLine()??"0");

                        if (posicaoRemocao >= 0 && posicaoRemocao < Sites.Count)
                        {
                            Site siteRemovido = Sites[posicaoRemocao];
                            Sites.RemoveAt(posicaoRemocao);
                            Console.WriteLine("Site removido: " + siteRemovido.Nome);
                        }
                        else
                        {
                            Console.WriteLine("Posição inválida. O site não foi removido.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Sites na lista:");
                        foreach (Site site in Sites)
                        {
                            Console.WriteLine("Nome: " + site.Nome + " | Link: " + site.Link);
                        }
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