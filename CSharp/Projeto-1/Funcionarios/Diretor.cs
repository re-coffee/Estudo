using LabCS.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Funcionarios
{
    class Diretor : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
        public Diretor(string CPF) : base(5000, CPF)
        {
            Console.WriteLine("Diretor.");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
