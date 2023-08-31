using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXE_3
{
    public class Turma
    {
        private int codigo;
        private int ano;

        public Turma(int codigo, int ano)
        {
            this.codigo = codigo;
            this.ano = ano;
        

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int novoCodigo)
        {
            codigo = novoCodigo;
        }

        public int GetAno()
        {
            return ano;
        }

        public void SetAno(int novoAno)
        {
            ano = novoAno;
        }
    }
}