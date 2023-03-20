using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crediaria
{
    internal class Ingles : Cursos
    {
        public string Descricao { get; set; }
        public string Duracao { get ; set; }
        public string Prof { get; set ; }
        public int Qntd { get ; set ; }
        public string Varicao { get; set ; }

        public void constroi(string des, string dura, string prof, int qntd, string va)
        {
            Descricao = des;
            Duracao = dura;
            Prof = prof;
            Qntd = qntd;
            Varicao = va;

        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Descrição: " + Descricao);
            Console.WriteLine("Duração: " + Duracao);
            Console.WriteLine("Professor: " + Prof);
            Console.WriteLine("Quantidade de Alunos:" + Qntd);
            Console.WriteLine("Variação:" + Varicao);
        }
    }
}
