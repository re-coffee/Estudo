using LabCS.Funcionarios;
using LabCS.Sistema;
using System;

namespace LabCS
{
    class Program
    {
        public static object SistemaInterno { get; private set; }

        static void Main(string[] args)
        {
            GetTotalBonificacao();
            Logar();
            Console.ReadLine();
        }

        public static void Logar()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor nayra = new Diretor("789789");
            nayra.Senha = "123";
            GerenteDeConta shay = new GerenteDeConta("000000");
            shay.Senha = "abc";

            sistema.Logar(shay, "123");
            sistema.Logar(nayra, "123");

        }
        public static void GetTotalBonificacao()
        {
            Auxiliar rennan = new Auxiliar("123123");
            Designer gabi = new Designer("456456");
            Diretor nayra = new Diretor("789789");
            GerenteDeConta shay = new GerenteDeConta("000000");

            GerenciadorBonificacao bonificacao = new GerenciadorBonificacao();

            bonificacao.Registrar(rennan);
            bonificacao.Registrar(gabi);
            bonificacao.Registrar(nayra);
            bonificacao.Registrar(shay);

            Console.WriteLine("total de bonificação do mês é: R$ " + bonificacao.TotalBonificacao + ".");

        }
    }
}
