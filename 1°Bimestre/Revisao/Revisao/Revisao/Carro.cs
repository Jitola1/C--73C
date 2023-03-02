using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Carro : IVeiculo
    {
        public string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ano { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Portas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowInfo()
        {
            Console.WriteLine($"{Marca} - {Modelo}");
            Console.WriteLine($"Quantidade de Portas: {Portas}");
        }

        public void MostrarCarro()
        {
            Console.WriteLine($"{Marca}- {Modelo} ");
            Console.WriteLine($"{Ano}- {Portas} portas ");
        }
    }
}
