using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Revisao0803
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia a classe = criando um objeto 
            Pessoa p1 = new Pessoa("Pedro", 19); //{ Nome = "Pedro", Idade = 19 };//Criando o objeto, já com os valores iniciais definidos no método contrutot
            p1.Nome = "Pedro";

            Console.WriteLine("Nome: " + p1.Nome);
            p1.Info();
            p1.Info("Pedro", "4478816832", "24444242");
            p1.Info("aaaaaaaa");

            Crianca c1 = new Crianca();
            Caminhao cam = new Caminhao();
            cam.Info();

            Console.ReadKey();
        }
    }
}
