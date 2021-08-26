using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(double salario, string CPF)
        {
            Salario = salario;
            Cpf = CPF;
            Console.Write("Instanciou mais um Funcionário do tipo ");
            TotalDeFuncionarios++;
        }
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
