using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Funcionarios
{
    public class Funcionario
    {
        //0 - funcionario
        //1 - diretor
        //2- designer
        //3 - gerente de conta corrente
        //4 - Coordenador
        // n - ----
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
        public double GetBonificacao()
        {
            if (_tipo == 1)            
               return Salario;
            

            return Salario * 0.10;
        }
    }
}
