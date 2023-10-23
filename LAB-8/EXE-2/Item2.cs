using System;

namespace Lab8_2
{
    class Item
    {
        private String entrada;
        public String Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        public Item(String entrada)
        {
            this.entrada = entrada;
        }
        public Item()
        {
            entrada = "";
        }


    }

}