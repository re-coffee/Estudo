using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Modelos
{
    public class ValorInvalidoException : ArgumentException
    {
        public ValorInvalidoException() { }
        public ValorInvalidoException(string mensagemErro) : base(mensagemErro) { }
        public ValorInvalidoException(string mensagemErro, string nomeParametro) : base(mensagemErro, nomeParametro) { }
    }
}