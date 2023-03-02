using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Pessoa
    {

        public string Nome { get; set; }

        public string Rg { get; set; }

        public String Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

       public void MostrarInformacoes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("RG " + Rg);
            Console.WriteLine("Data de Nascimento " + DataNascimento);

           
        }
        public void MostrarInformacoes(string nome, string rg, string cpf, DateTime dtNasc)
        {
            Console.Write($"Nom:> {nome} | CPF:" +
                $"{cpf} | RG: {rg} | Data de Nascimento: {dtNasc}");
        }
    }
}
