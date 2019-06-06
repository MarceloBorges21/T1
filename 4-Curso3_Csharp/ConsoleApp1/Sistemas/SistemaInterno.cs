using ConsoleApp1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sistemas
{
	class SistemaInterno
	{
		public bool Logar(Autenticavel funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);
			if (usuarioAutenticado)
			{
				Console.WriteLine("Bem vindo ao sistema");
				return true;
			}
			else
			{
				Console.WriteLine("Senha Incorreta");
				return false;
			}
		}
	}
}
