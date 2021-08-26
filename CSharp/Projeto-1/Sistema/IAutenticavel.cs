using LabCS.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabCS.Sistema
{
    public interface IAutenticavel
    {
        string Senha { get; set; }
        bool Autenticar(string senha);
    }
}
