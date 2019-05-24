// using _05_ByteBank;

using ByteBank.excecoes;
using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
      
        public int Agencia { get; }
            
        public int Numero { get; }
         

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0)  
            {
                throw new ArgumentException("O argumento agencia deve ser maior que zero.", nameof(numeroAgencia)) ;
            }
            if(numeroConta <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que zero.", nameof(numeroConta));
            }
            Agencia = numeroAgencia;
            Numero = numeroConta;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque." , nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsufucienteException(_saldo, valor);
            }

            _saldo -= valor;
           
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a transferencia.", nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
            
        }
    }
}
