using System;

namespace Lab8_2
{
    
     class Celula
    {
        private Item entrada;
        private Celula? proximo;
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public Item Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        public Celula()
        {
            entrada = new Item();
            proximo = null;
        }
        public Celula(Item entrada)
        {
            this.entrada = entrada;
            proximo = null;
        }
        public Celula(Item entrada, Celula proximo)
        {
            this.entrada = entrada;
            this.proximo = proximo;
        }
    }

}