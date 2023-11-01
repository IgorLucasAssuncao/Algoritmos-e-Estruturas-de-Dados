using System;

namespace Lab_10_2
{
    class Impressao
    {
        public string Nome { get; set; }
        public int NumPaginas { get; set; }

        public Impressao(string nome, int numPaginas)
        {
            Nome = nome;
            NumPaginas = numPaginas;
        }

        public Impressao()
        {
            Nome = "";
            NumPaginas = 0;
        }
        public void imprimir()
        {
            Console.WriteLine("Nome -> " + Nome);
            Console.WriteLine("NumPaginas -> " + NumPaginas);
        }
    }
}