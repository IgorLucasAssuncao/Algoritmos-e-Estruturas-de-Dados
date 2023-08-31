using System;
using System.ComponentModel;

namespace LAB_2
{
    class Contato
    {
        private string nome;
        private string telefone;
        private string email;
        private Data nascimento;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Data Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        public Contato(string nome, string telefone, string email, Data nascimento)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.nascimento = nascimento;
        }
        public Contato(string nome, string telefone, string email, int dia, int mes)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            nascimento = new Data(dia, mes);
        }
        public static Contato CriarContato()
        {
            Contato NovoContato = new Contato("", "", "", 0, 0);

            Console.WriteLine("Insira os dados:");
            Console.WriteLine("Nome: ");
            NovoContato.Nome = Console.ReadLine() ?? "0";
            Console.WriteLine("Telefone:");
            NovoContato.Telefone = Console.ReadLine() ?? "0";
            Console.WriteLine("Email: ");
            NovoContato.Email = Console.ReadLine() ?? "0";
            Console.WriteLine("Data de aniversário(Mês e dia)");
            int dia = int.Parse(Console.ReadLine() ?? "0");
            int mes = int.Parse(Console.ReadLine() ?? "0");
            NovoContato.Nascimento = new Data(dia, mes);

            return NovoContato;
        }

    }
}