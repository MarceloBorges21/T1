using ConsoleApp1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
		public Diretor(string cpf) : base(5000.00 ,cpf)
		{}
		
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
			return Salario * 0.5;
		}

    }
	
}
