using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProject.Modelo
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; private set; }
        public Cliente cliente { get; set; }
        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }
        public void Depositar(double valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
            }
        }
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
        }
        public void Transferir(ContaCorrente destino, double valor)
        {
            Sacar(valor);
            destino.Depositar(valor);
            
        }
        public override string ToString()
        {
            return $"Agencia: {Agencia} | Numero: {Numero} | Titular: {cliente.Nome} | Saldo: {Saldo}";
        }

    }
}
