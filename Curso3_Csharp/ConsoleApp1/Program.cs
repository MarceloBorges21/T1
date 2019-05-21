
using ConsoleApp1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);
            {
                carlos.Nome = "Carlos";
                carlos.CPF = "123";
                carlos.Salario = 2000;

            }
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("R$"+carlos.Salario);
            Console.ReadKey();
        }
    }
}
