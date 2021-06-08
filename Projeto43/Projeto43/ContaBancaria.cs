using System;
using System.Globalization;

namespace Projeto43
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double SaldoDaConta { get; private set; }

        public ContaBancaria(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
        public ContaBancaria(int conta, string nome, double saldo) : this(conta, nome)
        {
            SaldoDaConta = saldo;
        }
        public ContaBancaria()
        {

        }
          
        public void Deposito(double deposito)
        {
             SaldoDaConta += deposito;
        }
        public void Saque(double saque)
        {
            SaldoDaConta -= saque + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
    