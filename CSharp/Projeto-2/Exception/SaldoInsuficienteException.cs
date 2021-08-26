using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDois
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("tentativa de saque de valor R$ " + valorSaque + " para uma conta com saldo de R$ " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string message)
                : base(message) { }
        public SaldoInsuficienteException(string message, Exception excecaoInterna)
            :base(message, excecaoInterna) { }
    }
}
