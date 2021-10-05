using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparador
{
    class ClientePorCliente : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            return x.Nome.CompareTo(y.Nome);
        }
    }
}
