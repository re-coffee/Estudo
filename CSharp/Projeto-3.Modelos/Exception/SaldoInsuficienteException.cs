using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Modelos
{
    public class SaldoInsuficienteException : ValorInvalidoException
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string mensagemErro) : base(mensagemErro) { }
        public SaldoInsuficienteException(string nomeParametro, double valorSaque, double valorSaldo)
            : base("Saldo insuficiente para realizar a operação. Valor de saque: R$ " + valorSaque + "\nSaldo atual: R$ " + valorSaldo 
                  , nomeParametro) { }
    }
}
