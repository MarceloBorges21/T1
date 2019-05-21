
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario carlos = new Funcionario();           
            carlos.Nome = "Carlos";
            carlos.CPF = "123";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "4321";
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);
        
            
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("R$"+carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine("R$" + roberta.GetBonificacao());

            Console.WriteLine("Total de bonificação:  R$" + gerenciador.GetTotalBonificacao());


            Console.ReadKey();
        }
    }
}
