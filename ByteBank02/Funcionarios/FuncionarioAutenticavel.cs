using ByteBank02.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank02.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
