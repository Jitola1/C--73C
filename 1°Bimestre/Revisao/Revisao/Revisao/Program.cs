using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p = new Pessoa() { Nome = "Ana", Rg = "22212", Cpf = "121423" };

            // p.DataNascimento = new DateTime(2000, 1, 1);

            // p.MostrarInformacoes();
            // p.MostrarInformacoes("Paulo", "1343","231", new DateTime(1999,12,12));

            Casa casa = new Casa();

            casa.Tamanho = 100.00;
            casa.Orcamento = 50.00;
            //casa.Nome = "Residencal";
            casa.Engenheiro = "Francisco Silva";
            casa.PossuiPlanta = true;
            casa.MostrarEdificacao();
            casa.Nome = "aulo Ribeiro";

            Console.ReadKey();
        }
  
    }

}
