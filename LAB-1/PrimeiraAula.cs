/*using System;

namespace LAB_1
{

    class LAB_1
    {



        public static void Main(string[] args)
        {
            /*
                        double[,] mat = new double[12, 4];
                        string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
                        double[] soma = new double[12];
                        Random rd = new Random();
                        double SomaAno = 0;
                        double[] somaSemana = new double[4];
                        double maior_Compara = somaSemana[0];
                        int maior = 0;

                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                double random = rd.NextDouble();
                                mat[i, j] = random;
                                soma[i] += mat[i, j];
                            }
                        }

                        for (int i = 0; i < 12; i++)
                        {
                            Console.WriteLine("Valor para o mês de {0}: {1}", mes[i], soma[i].ToString("0.000"));
                        }

                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 12; j++)
                            {

                                SomaAno += mat[j, i];
                            }

                        }
                        int Ano = DateTime.Now.Year;
                        Console.WriteLine("Valor para o ano de {0}: {1}", Ano, SomaAno.ToString("0.000"));

                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 12; j++)
                            {
                                somaSemana[i] += mat[j, i];
                            }

                        }
                        for (int i = 0; i < 4; i++)
                        {

                            if (maior_Compara < somaSemana[i])
                            {
                                maior_Compara = somaSemana[i];
                                maior = i;
                            }
                        }
                        Console.WriteLine("A melhor semana para vender é a {0}ª semana", maior + 1);
                        */
            /*
                int numero_atual = 0, numero_anterior = 0, tamanho_sequencia = 0;

                Console.WriteLine("Digite uma sequência de números inteiros positivos terminada em -1");
                while (numero_atual != -1)
                {
                    numero_atual = int.Parse(Console.ReadLine());
                    if (numero_atual > numero_anterior)
                    {
                        tamanho_sequencia++;
                    }
                    else if (numero_atual != -1)
                    {
                        tamanho_sequencia = 1;
                    }
                    numero_anterior = numero_atual;
                }
                Console.WriteLine("A maior sequencia crescente e de {0} numeros", tamanho_sequencia);
            */
            /*
                        int limite = 0;
                        double valor = 0;

                        Console.WriteLine("Digite o limite de loops: ");
                        limite = int.Parse(Console.ReadLine() ?? "0");

                        for (int i = 0, x = 1; i < limite; i++, x += 2)
                        {
                            if (i % 2 == 1)
                            {
                                valor += 4 / x;
                            }
                            else
                            {
                                valor -= 4 / x;
                            }
                        }
                        Console.WriteLine("O valor é {0}", valor.ToString("0.00"));
            

            int[] x = new int[5];
            int[] y = new int[5];
            int[] uniao = new int[5];
            Random rd = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rd.Next(0, 10);
                y[i] = rd.Next(0, 10);
            }
            for (int i = 0; i < uniao.Length; i++)
            {
                uniao[i] = 0;
            }
            for (int i = 0; i < x.Length; i++)
            {
                int soma = x[i] + y[i];
                Console.WriteLine($"A soma na posição {i} é {soma}");

            }
            for (int i = 0; i < x.Length; i++)
            {
                int mult = x[i] + y[i];
                Console.WriteLine($"A multiplicação na posição {i} é {mult}");

            }
            for (int i = 0; i < x.Length; i++)
            {
                bool diferenca = false;
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] != y[j])
                    {
                        diferenca = true;
                    }
                }
                if (diferenca)
                {
                    Console.WriteLine($"O valor {x[i]} é diferente");
                }
            }

            for (int i = 0; i < x.Length; i++)
            {
                bool diferenca = false;
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        diferenca = true;
                    }
                }
                if (diferenca)
                {
                    Console.WriteLine($"Os valores iguais são {x[i]} (intersecção)");
                }
            }
            //Uniao entre x e y: todos os elementos de x, e todos os elementos de y que nãoestão em x.

            for (int i = 0; i < x.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < y.Length; j++)
                {
                    if (y[i] != x[j])
                    {
                        cont++;
                    }
                }
                if (cont == 5)
                {
                    for (int k = 0; k < uniao.Length; k++)
                    {
                        if (uniao[k] == 0)
                        {
                            uniao[k] = y[i];
                            break;
                        }
                    }

                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"A união é {x[i]}");
            }
            for (int i = 0; i < uniao.Length; i++)
            {
                if (uniao[i] != 0)  
                {
                    Console.WriteLine($"A união é {uniao[i]}");
                }
            }
        }
    }
}


*/