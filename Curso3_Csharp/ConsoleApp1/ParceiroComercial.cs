using ConsoleApp1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	 public class ParceiroComercial : Autenticavel
	{
		public string Senha { get; set; }
		public bool Autenticar(string senha)
		{
			return Senha == senha;
		}
	}
}
