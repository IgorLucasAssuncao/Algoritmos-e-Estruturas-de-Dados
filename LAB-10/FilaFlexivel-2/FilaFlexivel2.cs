/*using System;

namespace Lab_10_2
{
    class FilaFlex
    {
        private Cel frente;
        private Cel tras;

        public FilaFlex()
        {

            Cel sentinela;

            sentinela = new Cel();
            frente = sentinela;
            tras = sentinela;
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

        public void enfileirar(Impressao novo)
        {

            Cel novaCel;

            novaCel = new Cel(novo);

            tras.Proximo = novaCel;
            tras = novaCel;
        }

        public Impressao desenfileirar()
        {

            Cel CelDesenfileirada;
            Cel proximaCel;

            if (!filaVazia())
            {

                CelDesenfileirada = frente.Proximo;
                proximaCel = CelDesenfileirada.Proximo;
                frente.Proximo = proximaCel;

                if (CelDesenfileirada == tras) // se a célula retirada for a última célula da fila
                    tras = frente;

                return (CelDesenfileirada.Item);
            }
            else
                throw new Exception("Não foi possível desenfileirar nenhum item: a fila está vazia!");
        }

        public void imprimir()
        {

            Cel aux;

            if (!filaVazia())
            {
                Console.WriteLine("Conteúdo da fila:");

                aux = frente.Proximo;

                while (aux != null)
                {
                    aux.Item.imprimir();
                    aux = aux.Proximo;
                }
            }
            else
                throw new Exception("Não foi possível imprimir o conteúdo da fila: a fila está vazia!");
        }

        public int TamanhoFila()
        {
            int tamanho = 0;
            Cel aux = frente.Proximo; // Comece a partir do primeiro elemento (após o sentinela).

            while (aux != null)
            {
                tamanho++;
                aux = aux.Proximo;
            }

            return tamanho;
        }
        public Impressao PrimeiroNaFila()
        {
            if (!filaVazia())
            {
                return frente.Proximo.Item;
            }
            else
            {
                throw new Exception("A fila está vazia, não há um primeiro item.");
            }
        }
    }
}
*/