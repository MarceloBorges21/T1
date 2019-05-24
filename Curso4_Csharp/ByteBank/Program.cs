using ByteBank.excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(456, 44420);

                conta2.Transferir(-10, conta);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
            }
            catch (SaldoInsufucienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção para saldo insufuciente");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção para saldo augumento invalido");
            }
            Console.ReadKey();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por 0!");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Execeção com numero= " + numero + " e divisor= " + divisor);
                throw;
            }


        }
    }
}
