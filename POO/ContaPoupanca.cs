using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaPoupanca : Conta
    {
        // public int NumeroDaConta { get; set; }
        public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {
        }
        
    }
}
