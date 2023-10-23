/*
using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha Pia = new Pilha();
            string entrada;
            double x = 0, y = 0;

            Console.WriteLine("Escreva a entrada");
            entrada = Console.ReadLine();


            for (int i = 0; i < entrada.Length; i++)
            {

                switch (entrada[i])
                {
                    case '+':
                        x = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();
                        y = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();
                        Pia.empilhar(new Item(x + y));
                        break;

                    case '-':
                        x = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();
                        y = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();

                        if (x < y)
                            Pia.empilhar(new Item(y - x));
                        else
                            Pia.empilhar(new Item(x - y));

                        break;

                    case '/':
                        x = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();
                        y = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();

                        if (x < y)
                            Pia.empilhar(new Item(y / x));
                        else
                            Pia.empilhar(new Item(x / y));

                        break;

                    case '*':
                        x = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();
                        y = Pia.consultarTopo().Entrada;
                        Pia.desempilhar();
                        Pia.empilhar(new Item (x * y));
                        break;

                    default:

                        Pia.empilhar(new Item(double.Parse(entrada[i].ToString())));
                        break;
                }
            }
            Console.WriteLine($"Resultado: {Pia.consultarTopo().Entrada}");

        }
    }
}
*/