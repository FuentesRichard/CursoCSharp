using System;
using System.Globalization;
using Projeto64.Entities;

namespace Projeto64.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Imsposto()
        {
            if (Funcionarios < 10)
            {
                return (0.16 * RendaAnual);
            }
            else
            {
                return (0.14 * RendaAnual);
            }
        }
        public override string ToString()
        {
            return Nome + ": $" + Imsposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
