using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

    }
	
}
