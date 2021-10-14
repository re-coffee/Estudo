using IOProject.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IOProject
{
    partial class Program
    {
        static void testStreamReader()
        {
            var arquivo = "Contas.txt";
            //var buffer = new byte[1024]; // 1kb
            //var contadorDeByte = -1;
            //var utf8 = new UTF8Encoding();
            var lista = new List<ContaCorrente>();

            using (var stream = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(stream))
            {
                while (!leitor.EndOfStream)
                {
                    var spliter = leitor.ReadLine().Split(';');
                    var conta = new ContaCorrente(int.Parse(spliter[0]), int.Parse(spliter[1]));
                    conta.Depositar(double.Parse(spliter[2]));
                    conta.cliente = new Cliente();
                    conta.cliente.Nome = spliter[3];
                    lista.Add(conta);
                }
            }
            lista.EscreverNaTela();
            Console.ReadLine();
        }
    }
}
