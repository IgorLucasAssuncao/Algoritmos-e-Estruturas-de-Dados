using System;
using System.ComponentModel;
using System.Data;
using EXE_3;

namespace EXE_1
{
    class Aluno
    {
        private string nome;
        private int idade;
        private double peso;
        private bool formando = false;
        private char sexo;
        private Turma turma;

        public Aluno(string nome, int idade, double peso, char sexo, Turma turma)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.sexo = sexo;
            this.turma = turma;
        }
        public Aluno()
        {
            this.nome = "";
            this.idade = 0;
            this.peso = 0;
            this.sexo = 'M';
            this.turma = new Turma(0, 0);
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public bool Formando
        {
            get { return formando; }
            set { formando = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public Turma Turma
        {
            get { return turma; }
            set { turma = value; }
        }
    }
}