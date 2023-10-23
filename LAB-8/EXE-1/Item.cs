using System;

namespace Lab8
{
    class Item
    {
        private Double entrada;
        public Double Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        public Item(Double entrada)
        {
            this.entrada = entrada;
        }
        public Item()
        {
            entrada = 0.0;
        }


    }

}