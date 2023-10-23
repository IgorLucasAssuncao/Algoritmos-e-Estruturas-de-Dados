/*using System;
using System.Collections.Generic;


namespace Lab8_2
{
    class Program
    {
        static bool VerificarSequenciaBemFormada(string sequencia)
        {
            Pilha Pia = new Pilha();

            for (int i = 0; i < sequencia.Length; i++)
            {
                char charAtual = sequencia[i];

                if (charAtual == '(' || charAtual == '[')
                {
                    Pia.empilhar(new Item(charAtual.ToString()));
                }
                else if (charAtual == ')' || charAtual == ']')
                {
                    if (Pia.pilhaVazia())
                    {
                        return false;
                    }

                    char charTopo = char.Parse(Pia.consultarTopo().Entrada);

                    if ((charAtual == ')' && charTopo == '(') || (charAtual == ']' && charTopo == '['))
                    {
                        Pia.desempilhar();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return Pia.pilhaVazia();
        }

        static void Main(string[] args)
        {
            Console.Write("Digite a sequência de parênteses e colchetes: ");
            string sequencia = Console.ReadLine();

            if (VerificarSequenciaBemFormada(sequencia))
            {
                Console.WriteLine("A sequência está bem-formada.");
            }
            else
            {
                Console.WriteLine("A sequência está malformada.");
            }
        }
    }
}*/