using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Conta
    {
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; set; }

        public Conta(int numero_da_conta, double limite)
        { 
            this.Numero = numero_da_conta;
            this.Limite = limite;
            Conta.TotalDeContasCriadas++;
        }

        public static int ProximoTotalDeContasCriadas() 
        {
            return Conta.TotalDeContasCriadas += 1;
        }
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            double saldoDisponivel = this.ConsultarSaldoDisponivel();
            if (valor > saldoDisponivel) return false;

            this.Saldo -= valor;
            return true;
        }

        public double ConsultarSaldoDisponivel()
        { 
            return this.Saldo + this.Limite;
        }

        public void AlterarLimite(double valor)
        {
            this.Limite = valor;
        }
    }
}
