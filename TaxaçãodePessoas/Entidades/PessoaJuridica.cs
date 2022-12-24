using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaçãodePessoas.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumerodeFuncionarios { get; private set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(int funcionarios, string nome, double renda_anual) : base(nome, renda_anual)
        {
            NumerodeFuncionarios = funcionarios;
        }

        public override double impostos()
        {
            if (NumerodeFuncionarios>10)
            {
                return Renda_anual * 0.14;
            }
            else
            {
                return Renda_anual * 0.16;
            }
        }
    }
}
