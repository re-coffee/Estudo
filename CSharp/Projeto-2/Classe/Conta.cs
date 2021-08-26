using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDois
{
    abstract class Conta : IConta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; }
        public int Agencia { get; }
        public double Saldo { get; protected set; }
        public static int TotalContasCriadas { get; protected set; }
        public double Taxa { get; private set; }

        public Conta(int numero, int agencia)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento deve ser maior que zero.", nameof(numero));
            }
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento deve ser maior que zero.", nameof(agencia));
            }

            Agencia = agencia;
            Numero = numero;

            TotalContasCriadas++;
            Taxa = TotalContasCriadas / 30;
        }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito < 0)
            {
                throw new ArgumentException("Valor de depósito inválido.", nameof(valorDeposito));
            }
            Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            if (Saldo < valorSaque)
            {
                throw new SaldoInsuficienteException(Saldo, valorSaque);
            }
            if (valorSaque < 0)
            {
                throw new ArgumentException("Valor de saque inválido.", nameof(valorSaque));
            }
            Saldo -= valorSaque;
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (valorTransferencia < 0)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valorTransferencia));
            }
            try
            {
                Sacar(valorTransferencia);
            }
            catch(SaldoInsuficienteException ex)
            {
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valorTransferencia);
        }

    }
}
