using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal class Caminhao : Veiculo //Herdando uma classe abstrata
    {
        public override void MostrarProprietario() //Sobrescrevendo o método abstrato
        {
            Console.WriteLine("Proprietario");
        }
    }
}
