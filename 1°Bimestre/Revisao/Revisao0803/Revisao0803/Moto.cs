using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal class Moto : IVeiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void Info()
        {
            Console.WriteLine("info");
        }
    }
}
