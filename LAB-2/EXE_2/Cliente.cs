using System;


namespace EXE_2
{
    using System;

    class Cliente
    {
        private int codigo;
        private string nome;
        private bool eClienteEspecial;
        private double limiteCredito;

        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.limiteCredito = 0;
            this.eClienteEspecial = false;
        }

        public string GetNome()
        {
            return nome;
        }

        public bool AtualizarLimite(double novoLimite)
        {
            if (eClienteEspecial)
            {
                limiteCredito = novoLimite;
                return true;
            }
            return false;
        }

        public void AtualizarCategoria(bool novoValor)
        {
            eClienteEspecial = novoValor;
            if (!novoValor)
            {
                limiteCredito = 0;
            }
        }
    }
}