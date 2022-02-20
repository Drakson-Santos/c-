using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class GerenteDeTi : Gerente
    {
        public override void ReajustarSalario()
        {
            this.Salario += 2200;
        }
    }
}
