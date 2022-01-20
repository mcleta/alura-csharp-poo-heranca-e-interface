using ByteBank02.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank02.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool userAutenticado = funcionario.Autenticar(senha);

            if (userAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
