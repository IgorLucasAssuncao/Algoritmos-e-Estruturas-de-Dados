/*using System;
namespace LAB_2
{
    class Teste
    {
        public static void Main()
        {
            bool opc = true;
            Contato c1 = new Contato("João", "Rua 1", "1234-5678", 1, 1);
            Contato c2 = new Contato("Maria", "Rua 2", "1234-5678", 2, 2);
            Contato c3 = new Contato("José", "Rua 3", "1234-5678", 3, 3);
            Agenda agenda2 = new Agenda(50);
            agenda2.AdicionarContato(c1);
            agenda2.AdicionarContato(c2);
            agenda2.AdicionarContato(c3);

            Agenda agenda = new Agenda(50);


            while (opc)
            {
                Console.WriteLine("Escolha a opção:");
                Console.WriteLine("1.Inserir contato");
                Console.WriteLine("2.Buscar contato");
                Console.WriteLine("3.Ver todos os contatos");
                Console.WriteLine("4.Encerrar programa");
                int x = int.Parse(Console.ReadLine() ?? "0");
                switch (x)
                {
                    case 1:
                        Contato NovoContato = new Contato("", "", "", 0, 0);
                        NovoContato = Contato.CriarContato();
                        agenda.AdicionarContato(NovoContato);
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome para pesquisa: ");
                        string nome = Console.ReadLine() ?? "0";
                        agenda.BuscarContato(nome);

                        break;
                    case 3:
                        agenda.ImprimeAgenda();
                        Console.WriteLine();
                        agenda2.ImprimeAgenda();
                        break;
                    case 4:
                        opc = false;
                        break;

                }

            }



        }
    }
}*/