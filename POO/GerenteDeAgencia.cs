using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class GerenteDeAgencia : Gerente
    {
        public override void ReajustarSalario()
        {
            this.Salario += 1200;
        }
    }
}
