using ConsoleApp1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sistemas
{
	public interface Autenticavel
	{
		bool Autenticar(string senha);		
	}
}
