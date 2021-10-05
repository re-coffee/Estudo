using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Modelos
{
    public abstract class Conta : IConta
    {
        public Cliente Titular { get; set; }
        public int NumeroAgencia { get; }
        public int NumeroConta { get; }
        public double SaldoConta { get; private set; }

        public Conta(Cliente titular, int numeroAgencia, int numeroConta)
        {
            Titular = titular;
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
        }
        public virtual void Depositar(int valorDeposito)
        {
            if(valorDeposito >= 0)
                throw new ValorInvalidoException("Valor de depósito não pode ser menor do que 0.");
            SaldoConta += valorDeposito;
        }

        public virtual void Sacar(int valorSaque)
        {
            if (valorSaque > SaldoConta)
                throw new SaldoInsuficienteException(nameof(SaldoConta), valorSaque, SaldoConta);
            SaldoConta += valorSaque;
        }

        public virtual void Transferir(int valorTransferencia, Conta contaDestino)
        {
            Sacar(valorTransferencia);
            contaDestino.Depositar(valorTransferencia);
        }
    }
}
