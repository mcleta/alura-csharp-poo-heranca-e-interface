using ByteBank02.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank02.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            return;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
