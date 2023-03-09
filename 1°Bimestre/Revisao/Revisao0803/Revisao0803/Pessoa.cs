using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int Idade { get; set; }

        //Metodo Construtor
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public Pessoa()
        {
            
        }

        //Sobrecarga
        public void Info()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Rg: " + Rg);
            Console.WriteLine("CPF: " + Cpf);
        }

        public void Info(string nome, string rg, string cpf)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Nome: " + rg);
            Console.WriteLine("Nome: " + cpf);
        }

        public void Info(string info)
        {
            Console.WriteLine(info);
        }

        // Método que pode ser sobrescrito
        public virtual void AdicionarSobrenome(string sobrenome)
        {
            Nome = Nome + " " + sobrenome;
        }

    }
}
