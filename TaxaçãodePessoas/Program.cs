using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxaçãodePessoas.Entidades;

namespace TaxaçãodePessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contribuintes, funcionarios;
            char type;
            string nome;
            double renda,despesasMed;
            List<Contribuinte> pagantes = new List<Contribuinte>();
            Console.Write("Número de contribuintes: ");
            contribuintes = int.Parse(Console.ReadLine());
            for (int i = 0; i < contribuintes; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i+1}");
                Console.Write("Individuo ou Empresa (i/e)? ");
                type = Console.ReadLine()[0];
                Console.Write("Nome:");
                nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                renda = double.Parse(Console.ReadLine());
                if (type=='i')
                {
                    Console.Write("Gastos com saúde: ");
                    despesasMed = double.Parse(Console.ReadLine());
                    PessoaFisica pessoaFisica = new PessoaFisica(despesasMed, nome, renda);
                    pagantes.Add(pessoaFisica);
                }
                else
                {
                    Console.Write("Número de funcionários: ");
                    funcionarios = int.Parse(Console.ReadLine());
                    PessoaJuridica pessoaJuridica = new PessoaJuridica(funcionarios, nome, renda);
                    pagantes.Add(pessoaJuridica);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Impostos Pagos:");
            foreach (Contribuinte var in pagantes)
            {
                Console.WriteLine(var.impostos().ToString("F2"));
            }
        }
    }
}
