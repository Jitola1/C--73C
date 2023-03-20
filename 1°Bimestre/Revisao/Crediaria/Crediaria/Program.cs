using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crediaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia a classe = criando um objeto 
            bool cad = false;
            while (!cad)
            {
                Console.WriteLine();
                Console.WriteLine("Digite a Raça do Animal:");
                string Raca = Console.ReadLine();
                Console.WriteLine("Digite a Idade do Animal:");
                string idade = Console.ReadLine();
                Console.WriteLine("Digite a Cor do Animal:");
                string cor = Console.ReadLine();
                Console.WriteLine("Digite se há ferimentos(1-SIM, 2- NÃO):");
                int ferimentos = int.Parse(Console.ReadLine());
                bool feri = ferimentos == 1 ? true : false;
                Animais A1 = new Animais(Raca, idade, cor, feri);
                A1.Info();

                Console.WriteLine();
                Console.WriteLine("Deseja Cadastrar mais animais? 1-SIM 2-NÃO");
                int boola = int.Parse(Console.ReadLine());
                bool bo = boola == 1 ? true : false;
                if(bo == true)
                {
                    cad = false;
                }
                else
                {
                    cad = true;
                }
            }
            Console.WriteLine("Cadastro/s concluido");
            bool cur = false;
            while (!cur)
            {
                Console.WriteLine();
                Console.WriteLine("Qual curso gostaria de ver?");
                Console.WriteLine("1-Inglês, 2-Espanhol, 3- Italiano, 4- Mandarim e Japonês, 5-Encerrar");
                string boola = Console.ReadLine();
                int bo = int.Parse(boola);
                switch (bo)
                {
                    case 1:
                        Ingles Ing = new Ingles();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string des = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string dura = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string prof = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int qntd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Variação: ");
                        string va = Console.ReadLine();
                        Ing.constroi(des, dura,prof,qntd,va);
                        Ing.Info();

                        break;
                    case 2:
                        Espanho Esp = new Espanho();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string des1 = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string dura1 = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string prof1 = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int qntd1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Variação: ");
                        string va1 = Console.ReadLine();
                        Esp.constroi(des1, dura1, prof1, qntd1, va1);
                        Esp.Info();

                        break;
                    case 3:
                        Italiano italiano = new Italiano();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string des2 = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string dura2 = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string prof2 = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int qntd2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Variação: ");
                        string va2 = Console.ReadLine();
                        italiano.constroi(des2, dura2, prof2, qntd2, va2);
                        italiano.Info();
                        break;
                    case 4:
                        Japa japa = new Japa();
                        Console.WriteLine();
                        Console.WriteLine("Descrição: ");
                        string des3 = Console.ReadLine();
                        Console.WriteLine("Duração: ");
                        string dura3 = Console.ReadLine();
                        Console.WriteLine("Professor: ");
                        string prof3 = Console.ReadLine();
                        Console.WriteLine("Quantidade de Alunos: ");
                        int qntd3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Variação: ");
                        string va3 = Console.ReadLine();
                        japa.constroi(des3, dura3, prof3, qntd3, va3);
                        japa.Info();
                        break;
                    case 5:
                        cur = true;
                        break;

                    default:
                        Console.WriteLine("Nenhuma Opção escolhida");
                        break;
                }
                
            }


            Console.WriteLine("Leitura de cursos concluida");
            Console.ReadKey();
        }
    }
}
