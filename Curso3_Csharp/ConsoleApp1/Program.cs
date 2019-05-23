
using ConsoleApp1.Funcionarios;
using ConsoleApp1.Sistemas;
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
			//CalcularBonificacao();

			UsarSistema();

			Console.ReadKey();
        }
		public static void UsarSistema()
		{
			SistemaInterno sistemaInterno = new SistemaInterno();
			Diretor roberta = new Diretor("159.753.398-05");
			roberta.Nome = "Roberta";
			roberta.Senha = "123";

			GerenteDeConta camila = new GerenteDeConta("12345");
			camila.Nome = "Camila";
			camila.Senha = "abc";

			ParceiroComercial parceiro = new ParceiroComercial();
			parceiro.Senha = "123456";

			sistemaInterno.Logar(parceiro, "123456");
			sistemaInterno.Logar(roberta, "123");
			sistemaInterno.Logar(camila, "abc");

		}

		public static void CalcularBonificacao()
		{
			GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

			Funcionario pedro = new Designer("833.222.048-09");
			pedro.Nome = "Pedro";
			Console.WriteLine("Nome: "+pedro.Nome + " | Salario: R$" + pedro.Salario);
			Console.WriteLine();

			Funcionario roberta = new Diretor("159.753.398-05");
			roberta.Nome = "Roberta";
			Console.WriteLine("Nome: " + roberta.Nome + " | Salario: R$" + roberta.Salario);
			Console.WriteLine();

			Funcionario igor = new Auxiliar("981.198.778-12");
			igor.Nome = "Igor";
			Console.WriteLine("Nome: " + igor.Nome + " | Salario: R$" + igor.Salario);
			Console.WriteLine();

			Funcionario camila = new GerenteDeConta("326.985.628-32");
			camila.Nome = "Camila";
			Console.WriteLine("Nome: " + camila.Nome + " | Salario: R$" + camila.Salario);
			Console.WriteLine();

			Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
			guilherme.Nome = "Guilherme";
			Console.WriteLine("Nome: " + guilherme.Nome + " | Salario: R$" + guilherme.Salario);
			Console.WriteLine();

			gerenciadorBonificacao.Registrar(guilherme);
			gerenciadorBonificacao.Registrar(pedro);
			gerenciadorBonificacao.Registrar(roberta);
			gerenciadorBonificacao.Registrar(igor);
			gerenciadorBonificacao.Registrar(camila);
			Console.WriteLine();
			Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
		}
    }
}
