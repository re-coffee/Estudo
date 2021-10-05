using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            var contas = new List<ContaCorrente>
            {
                new ContaCorrente(999, 999),
                new ContaCorrente(456, 456),
                new ContaCorrente(789, 789),
                new ContaCorrente(101, 101),
                new ContaCorrente(111, 111),
                new ContaCorrente(121, 121),
                new ContaCorrente(1, 1)
            };

            
            var lista = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);
            lista.EscreverNaTela();
            Console.ReadKey();

        }

        static void TestarMetodosDeExtensao()
        {
            var nomes = new List<Cliente>()
            {
                new Cliente("Rennan"),
                new Cliente("Luis"),
                new Cliente("Nayra"),
                new Cliente("Nene"),
                new Cliente("Karen"),
                new Cliente("Stephanie"),
                new Cliente("alo"),
                new Cliente("123")
            };

            nomes.Sort(new ClientePorCliente());

            nomes.EscreverNaTela();
        }

        static void TestaArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(123, 123),
                    new ContaCorrente(456, 456),
                    new ContaCorrente(789, 789)
                };

            for (int i = 0; i < contas.Length; i++)
            Console.WriteLine($"Conta {i}: número ({contas[i].Numero});\n");
        }
        static void TestaArrayInt()
        {
            int[] arrayIdades = new int[] 
                {
                    10, 10, 15, 10
                };
            int somaIdade = 0;

            foreach (int idade in arrayIdades)
                somaIdade += idade;

            Console.WriteLine(somaIdade / arrayIdades.Length);
        }

        static string DataEmDias(TimeSpan data)
        {
            return data.Days  + " dia(s)";
        }
    }
}
