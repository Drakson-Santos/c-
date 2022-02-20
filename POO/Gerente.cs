using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Gerente : Funcionario
    {
        public override void ReajustarSalario()
        {
            this.Salario += 1000;
        }
    }
}
