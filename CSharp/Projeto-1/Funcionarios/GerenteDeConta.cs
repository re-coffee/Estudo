using LabCS.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Funcionarios
{
    class GerenteDeConta : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
        public GerenteDeConta(string CPF) : base(4000, CPF)
        {
            Console.WriteLine("Gerente de conta.");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
