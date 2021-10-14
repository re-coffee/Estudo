using IOProject.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProject
{
    namespace IOProject
    {
        partial class Program
        {
            static void Main(string[] args)
            {
                var caminhoNovoArquivo = "contasExportadas.csv";
                using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
                using (new StreamWriter(fluxoDeArquivo))
                {

                }

                    Console.ReadLine();
            }
        }
    }
}
