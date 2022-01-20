using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank02.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            return;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
