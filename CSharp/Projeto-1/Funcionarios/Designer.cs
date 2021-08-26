using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Funcionarios
{
    class Designer : Funcionario
    {
        public Designer(string CPF) : base(3000, CPF)
        {
            Console.WriteLine("Designer.");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
