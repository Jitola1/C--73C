using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal interface IVeiculo // Implementa uma interface
    {
        // Nas interfaces eu somento declaro os métodos e suas assinaturas sem implementação
        string Marca { get; set; }
        string Modelo { get; set; }
        int Ano { get; set; }

        void Info();
    }
}
