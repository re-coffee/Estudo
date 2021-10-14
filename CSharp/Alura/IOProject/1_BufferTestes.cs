using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProject
{
    partial class Program
    {
        static void testeFileStream()
        {
            var arquivo = "Contas.txt";
            var stream = new FileStream(arquivo, FileMode.Open);
            var buffer = new byte[1024]; // 1kb
            var contadorDeByte = -1;

            var utf8 = new UTF8Encoding();

            while (contadorDeByte != 0)
            {
                contadorDeByte = stream.Read(buffer, 0, 1024);
                var texto = utf8.GetString(buffer, 0, contadorDeByte);
                texto.EscreverNaTela();

            }

            stream.Close();
            Console.ReadLine();
        }
    }
}
