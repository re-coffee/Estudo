using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Modelos
{
    interface IConta
    {
        void Sacar(int valorSaque);
        void Depositar(int valorDeposito);
        void Transferir(int valorTransferencia, Conta contaDestino);

    }
}
