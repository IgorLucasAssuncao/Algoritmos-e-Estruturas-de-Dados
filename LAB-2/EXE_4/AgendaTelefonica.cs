using System;
using System.ComponentModel;

namespace LAB_2
{
    class Agenda
    {
        private Contato[] contatos;
        private int qtdContatos;

        public Agenda(int tamanho)
        {
            contatos = new Contato[tamanho];
            qtdContatos = 0;
        }
        public void AdicionarContato(Contato contato)
        {
            if (qtdContatos < contatos.Length)
            {
                contatos[qtdContatos] = contato;
                qtdContatos++;
            }
            else
            {
                Console.WriteLine("Agenda cheia!");
            }
        }
        public void BuscarContato(string nome)
        {
            for (int i = 0; i < qtdContatos; i++)
            {
                if (contatos[i].Nome == nome)
                {
                    ImprimeContato(i);
                }
            }


        }
        public void ImprimeAgenda()
        {
            for (int i = 0; i < qtdContatos; i++)
            {
                Console.Write($"{contatos[i].Nome} ");
                Console.Write($"{contatos[i].Email} ");
                Console.Write($"{contatos[i].Telefone} ");
                Console.Write($"{contatos[i].Nascimento.Dia}");
                Console.Write($"{contatos[i].Nascimento.Mes}");
                Console.WriteLine();

            }
        }
        public void ImprimeContato(int i)
        {
            Console.Write($"{contatos[i].Nome} ");
            Console.Write($"{contatos[i].Email} ");
            Console.Write($"{contatos[i].Telefone} ");
            Console.Write($"{contatos[i].Nascimento.Dia}");
            Console.Write($"{contatos[i].Nascimento.Mes}");
            Console.WriteLine();

        }


    }
}