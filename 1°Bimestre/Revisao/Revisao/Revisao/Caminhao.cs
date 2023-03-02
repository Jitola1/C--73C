using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Caminhao : IVeiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int Ano { get; set; }
        public int Portas { get; set; } =2;

        public int Eixos { get; set; }
        string IVeiculo.Portas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowInfor()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Marca} - {Modelo}");
            Console.WriteLine($"{Ano} - {Eixos} eixos");
        }
    }
}
