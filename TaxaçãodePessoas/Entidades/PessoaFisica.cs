using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaçãodePessoas.Entidades
{
    internal class PessoaFisica : Contribuinte
    {
        public double Saude { get; private set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(double saude, string nome, double renda_anual) : base(nome, renda_anual)
        {
            Saude = saude;
        }

        public override double impostos()
        {
            if (Renda_anual<20000)
            {
                return Renda_anual * 0.15 - Saude * 0.5;
            }
            else
            {
                return Renda_anual*0.25-Saude * 0.5;
            }
        }

    }
}
