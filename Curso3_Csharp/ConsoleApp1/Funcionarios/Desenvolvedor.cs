using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
	class Desenvolvedor : Funcionario
	{
		public Desenvolvedor(string cpf) : base(3000, cpf)
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 0.15;
		}

		public override double GetBonificacao()
		{
			return Salario * 0.1;
		}
	}
}
