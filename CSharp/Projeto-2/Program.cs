using System;

namespace ProjetoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente rennan = new ContaCorrente(123, 456);
                ContaCorrente nayra = new ContaCorrente(789, 456);

                rennan.Transferir(100, nayra);

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            catch(OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("\n\nInformações da InnerException:\n");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);

            }

            Console.ReadLine();
        }
    }
}
