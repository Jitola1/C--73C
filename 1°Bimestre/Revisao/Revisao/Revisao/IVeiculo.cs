using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal interface IVeiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }

         int Ano { get; set; }

        string Portas { get; set; }

        void ShowInfo();


    }
}
