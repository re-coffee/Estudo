using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Modelos
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente titular, int numeroAgencia, int numeroConta)
            : base(titular, numeroAgencia, numeroConta) { }

    }
}
