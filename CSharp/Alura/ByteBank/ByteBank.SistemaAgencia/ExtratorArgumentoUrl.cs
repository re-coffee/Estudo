using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ExtratorArgumentoUrl
    {
        private readonly string _argumento;

        public string Url { get; }
        public ExtratorArgumentoUrl()
        {

        }
        public ExtratorArgumentoUrl(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("A url não pode ser nula ou vazia.", nameof(url));
            }
            
            Url = url;
            _argumento = Url.Substring(Url.IndexOf("?"));

        }
        public string GetValor(string argumento)
        {
            //moedaOrigem=Real&moedaDestino=Dolar
            argumento += "=";
            int indiceInicial = _argumento.ToLower().IndexOf(argumento.ToLower());
            string extracao = _argumento.Substring(indiceInicial + argumento.Length);
            int indiceEComercial = extracao.IndexOf('&');

            return indiceEComercial == -1 ? extracao : extracao.Remove(indiceEComercial);

        }
        public static string Late()
        {
            return "auauau";
        }
        public override string ToString()
        {
            return $"o método late {Late()}";
        }
    }
}
