/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXE_1
{
    public class TesteAluno
    {
        public static void Main()
        {
            string nome;
            int idade;
            double peso;
            Boolean formando = false;
            char sexo;
            Console.WriteLine("Entre com os valores para o aluno: ");
            Console.WriteLine();
            Console.WriteLine("Nome:");
            nome = Console.ReadLine() ?? "0";
            Console.WriteLine("Idade:");
            idade = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Peso: ");
            peso = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Agora insira o sexo, 'M' para masculino e 'F' para feminino:");
            sexo = char.Parse(Console.ReadLine() ?? "0");
            Aluno aluno1 = new Aluno(nome, idade, peso, sexo);

            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Idade: " + aluno1.Idade);
            Console.WriteLine("Peso: " + aluno1.Peso);
            Console.WriteLine("Sexo: " + aluno1.Sexo.ToString());
            Console.WriteLine("Formando: " + aluno1.Formando);
            Console.WriteLine();

            Console.WriteLine("Insira novamente esses valores:");
            Console.WriteLine("Idade:");
            idade = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Peso: ");
            peso = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("O aluno é formado?(true/false)");
            formando = bool.Parse(Console.ReadLine() ?? "0");
            aluno1.Idade = idade;
            aluno1.Peso = peso;
            aluno1.Formando = formando;

            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Idade: " + aluno1.Idade);
            Console.WriteLine("Peso: " + aluno1.Peso);
            Console.WriteLine("Sexo: " + aluno1.Sexo);
            Console.WriteLine("Formando: " + aluno1.Formando);
            Console.WriteLine();


        }

    }
}
*/