using System;
using System.Globalization;
using Projeto64.Entities;

namespace Projeto64.Entities
{
    class PessoaFisica : Pessoa
    {
        public double Saude { get; set; }

        public PessoaFisica()
        {

        }
        public PessoaFisica(double saude, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            Saude = saude;
        }

        public override double Imsposto()
        {
            if (RendaAnual < 20000.00)
            {
                return (0.15 * RendaAnual) - (Saude * 0.5);
            }
            else
            {
                return (0.25 * RendaAnual) - (Saude * 0.5);
            }
        }
        public override string ToString()
        {
            return Nome + ": $ " + Imsposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
