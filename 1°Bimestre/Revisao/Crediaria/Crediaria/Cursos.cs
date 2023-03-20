using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Crediaria
{
    internal interface Cursos
    {
         string Descricao { get; set; }
         string Duracao { get; set; }
        string Prof { get; set; }
        int Qntd { get; set; }
        string Varicao { get; set; }

        void constroi(string des, string dura, string prof, int qntd,string va);
        void Info();

        /*public Cursos(string descricao,string duracao,string prof, string qntd) {
            Descricao = descricao;
            Duracao = duracao;
            this.Prof = Prof;
            this.Qntd = qntd;
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Descrição: " + Descricao);
            Console.WriteLine("Duração: " + Duracao);
            Console.WriteLine("Professor: " + Prof);
            Console.WriteLine("Quantidade de Alunos:" + Qntd);
        }*/
    }
}
