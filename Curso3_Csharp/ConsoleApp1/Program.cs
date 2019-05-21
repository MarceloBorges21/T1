
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


            
            Funcionario carlos = new Funcionario("123");           
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("4321");
            roberta.Nome = "Roberta";          
            roberta.Salario = 5000;
            gerenciador.Registrar(roberta);
           
            
            Console.WriteLine(carlos.Nome);
            Console.WriteLine("10% so sálario R$"+carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine("R$" + roberta.GetBonificacao());

            Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Total de bonificação:  R$" + gerenciador.GetTotalBonificacao());


            Console.ReadKey();
        }
    }
}
