using LabCS.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS
{
    class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; protected set; }
        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();

        }

    }
}
