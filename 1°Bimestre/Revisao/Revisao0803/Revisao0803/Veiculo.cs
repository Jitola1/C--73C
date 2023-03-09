using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal abstract class Veiculo
    {
        public void Info()
        {
            Console.WriteLine("Informações");
        }

        public abstract void MostrarProprietario(); // método abstrato - a classe filha é obrigada a sobrescrever ela
    }
}
