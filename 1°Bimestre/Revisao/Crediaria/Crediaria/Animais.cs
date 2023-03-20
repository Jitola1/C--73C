using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crediaria
{
    internal class Animais
    {
        public string Raca { get; set; }
        public string Cor { get; set;}
        public string idade { get; set; }
        public bool ferimentos { get; set; }

        public Animais(string raca, string cor, string idade, bool ferimentos)        {
            Raca = raca;
            Cor = cor;
            this.idade = idade;
            this.ferimentos = ferimentos;
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Cor: "+ Cor);
            Console.WriteLine("Idade: "+ idade);
            Console.WriteLine("Ferimento:" + ferimentos);
        }

    }
}
