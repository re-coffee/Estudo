using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string CPF) : base(2000, CPF)
        {
            Console.WriteLine("Auxiliar.");
        }
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
