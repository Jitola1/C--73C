using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal class Crianca : Pessoa//Herança = Criança herda de Pessoa
                                    // ":" é usado para herança e implementação
    {


        public Crianca() : base() // faz com que se herda o contrutor
        {
            
        }

        //Método que vai sobrescrever
        public override void AdicionarSobrenome(string sobrenome)
        {
    
            Console.WriteLine("Por ser menor de idade, não pode fazer essa alteração");
        }
    }
}
