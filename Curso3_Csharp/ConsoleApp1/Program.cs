
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


            
            Funcionario carlos = new Funcionario(1054.00,"123-321-456-07");   //cpf        
            carlos.Nome = "Carlos";          
            gerenciador.Registrar(carlos);
            carlos.AumentarSalario();//metodo esta na calsse funcionairio

            Diretor roberta = new Diretor("291-124-345-09"); //cpf, salario 
            roberta.Nome = "Roberta";          
            gerenciador.Registrar(roberta);
            roberta.AumentarSalario();

            Console.WriteLine(carlos.Nome);
            Console.WriteLine("10% do sálario R$"+carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine("10% do sálario R$" + roberta.GetBonificacao());

            Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Total de bonificação:  R$" + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Novo sálario do Carlos com 10% de aumento R$" + carlos.Salario);
            Console.WriteLine("Novo sálario da Roberta com 15% de aumento R$" + carlos.Salario);

            Console.ReadKey();
        }
    }
}
