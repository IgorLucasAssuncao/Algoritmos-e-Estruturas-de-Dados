/*using System;
using System.Collections.Generic;

namespace FilaComum{
    class FilaComum{
        public static void Main(){
            string entrada="";
            int opcao=0;
            bool control=true;
            Queue<string> fila = new Queue<string>();  

            for(int i=1; i<11; i++){
                fila.Enqueue("Avião "+i);
            }

           while(control){
             Console.WriteLine("Bem vindo ao gerenciador da fila de aviões!");
             Console.WriteLine("1.Listar a quantidade de aviões que estão aguardando na fila de decolagem");
             Console.WriteLine("2.Autorizar a decolagem do primeiro avião da fila de decolagem (isto é, retirar da fila de decolagem)");
             Console.WriteLine("3.Adicionar um avião na fila de decolagem");
             Console.WriteLine("4.Listar todos os aviões que estão na fila de decolagem");
             Console.WriteLine("5.Exibir o primeiro avião da fila de decolagem");
             Console.WriteLine("6.Sair");
             Console.WriteLine("Digite a opção desejada:");

            opcao = int.Parse(Console.ReadLine()??"0");

            switch(opcao)
            {
                case 1:
                    Console.WriteLine("A quantidade de aviões na fila é: "+fila.Count);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("O avião "+fila.Dequeue()+" decolou!");
                    Console.WriteLine();                    break;
                case 3:

                    Console.WriteLine("Digite o nome do avião:");
                    entrada = Console.ReadLine();
                    fila.Enqueue(entrada);
                    Console.WriteLine("O avião "+entrada+" foi adicionado a fila!");
                    Console.WriteLine();
                    break;

                case 4:
                    foreach(string aviao in fila){
                        Console.WriteLine(aviao);
                    }
                    Console.WriteLine();
                    break;
                case 5:

                    Console.WriteLine("O primeiro avião da fila é: "+fila.Peek());
                    Console.WriteLine();
                    break;
                case 6:
                    control=false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                    break;
            }
           }
        }
    }

}
*/