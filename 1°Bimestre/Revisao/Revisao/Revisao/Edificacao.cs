using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    abstract class Edificacao
    {
        public abstract string Nome { get; set; }
        public double Tamanho { get; set; }

        public double Orcamento { get; set; }

        public string Engenheiro { get; set; }

        public bool PossuiPlanta { get; set; }

        public void MostrarEdificacao()
        {
            Console.WriteLine($"{Nome} - {Tamanho}");
            Console.WriteLine($"Eng {Engenheiro}");
        }
    }
}
