using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDois
{
    interface IConta
    {
        void Sacar(double valor);
        void Depositar(double valor);
    }
}
