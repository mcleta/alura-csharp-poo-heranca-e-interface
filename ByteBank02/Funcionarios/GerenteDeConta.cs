using ByteBank02.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank02.Funcionarios
{
    internal class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
            return;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
