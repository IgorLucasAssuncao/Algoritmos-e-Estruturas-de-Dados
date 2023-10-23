/*using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Lab_5{
    class EXE_1{
        public static void Main(){
            int limite=0;
            Console.WriteLine("Insira um limite:");
            limite = int.Parse(Console.ReadLine()??"0");
            Console.WriteLine($"o resultado é {Soma(limite)}");

            Console.WriteLine($"o resultado é {ImprimeSequencia(limite,0)}");
            int[] vet={1,2,3,4,5,6,7,8,9,10};
            int[] vet2={10,9,8,7,6,5,4,3,2,1};
            Console.WriteLine($"o maior elemento é: {RetornaMaior(vet, vet.Length-1)}");
            Console.WriteLine($"o maior elemento é: {RetornaMaior(vet2, vet2.Length-1)}");

            Console.WriteLine($"o resultado é {Tribonacci(0)}");
        }
        public static int Soma(int limite){////////////////////////////////////  1
            if(limite==1){
                return 1;
            }
            else{ 
                return limite+ Soma(--limite);
            }
        }

        public static dynamic ImprimeSequencia(int limite, int comeco){//////////////////////////// 2
            if(comeco==limite){
                return comeco.ToString();
            }else{
                return comeco.ToString()+","+ImprimeSequencia(limite, ++comeco);
            }
        }
        public static int RetornaMaior(int[] vet, int tamanho){//////////////////////////// 3
            if(tamanho==0){
                return vet[0];
            }else if(vet[tamanho]>vet[tamanho-1]){
                return vet[tamanho];
            }else{
                return RetornaMaior(vet, --tamanho);
            }
        }
        public static int RetornaNegativo(int[] vet, int tamanho){ //////////////////////////// 4
            if(tamanho==0){
                return (vet[0]<0)? 1 : 0;
            }else{
                return (vet[tamanho]<0? 1 : 0)+RetornaNegativo(vet, --tamanho);
            }
        }
            public static int Tribonacci(int n)//////////////////////////////// 5
            {
            if(n==0){
                return 0;
            }else if(n==1){
                return 0;
            }else if(n==2){
                return 1;
            }else{
                return Tribonacci(n-1)+Tribonacci(n-2)+Tribonacci(n-3);
            }
        

            }

        }
    }
*/