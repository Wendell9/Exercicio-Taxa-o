using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaçãodePessoas.Entidades
{
    abstract class Contribuinte
    {
        public string Nome { get; private set; }
        public double Renda_anual { get; private set; }

        public Contribuinte()
        {
        }

        public Contribuinte(string nome, double renda_anual)
        {
            Nome = nome;
            Renda_anual = renda_anual;
        }

        public abstract double impostos();
    }
}
