using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            if (funcionario.Senha == senha)
            {
                Console.WriteLine("bem vindo ao sistema!");
                return true;
            }
            Console.WriteLine("autenticação falhou.");
            return false;

        }
    }
}
