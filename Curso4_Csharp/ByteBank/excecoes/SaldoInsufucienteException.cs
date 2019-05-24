using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.excecoes
{
    class SaldoInsufucienteException : Exception
    {
        public double Saldo { get;}
        public double ValorSaque { get; }
        public SaldoInsufucienteException()
        {
        }

        public SaldoInsufucienteException(double saldo, double valorSaque)
            :this("Tentativa de saque no valor de R$"+valorSaque+" onde a conta possui apenas R$"+saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsufucienteException(string mensagem)
            :base(mensagem)
        {

        }
    }
}
