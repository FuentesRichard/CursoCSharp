using System;
using System.Globalization;

namespace Projeto38
{
    class Funcionario
    {
       
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            porcentagem = porcentagem / 100.00;
            SalarioBruto = SalarioBruto * porcentagem + SalarioBruto;
            return SalarioBruto;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + "$"
                + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
