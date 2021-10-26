using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    { 
        enum Menu {Soma=1, Subtracao , Multiplicacao, Divisao, Sair }
        static void Main(string[] args)
        {
            bool escolheusair = false;
            while (!escolheusair)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Bem vindo a sua calculadora:");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Sair");

                Menu opcao = (Menu) int.Parse(Console.ReadLine());
                Console.WriteLine(opcao);
                Console.ReadLine();

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Sair:
                        escolheusair = true;
                        break;
                }

            }
            
        }
        static void Soma()
        {
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"A Soma de dois números é : {resultado}");
            Console.WriteLine("Tecle o enter para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();
        }
        static void Sub()
        {
            Console.WriteLine("Digite o primiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"A Subtração de dois números é :{resultado}");
            Console.WriteLine("Tecle enter para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();
        }
        static void Mult()
        {
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"A Multiplicação de dois números é:{resultado}");
            Console.WriteLine("Tecle enter para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();
        }
        static void Div()
        {
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a / b;
            Console.WriteLine($"A Divisão de dois números é:{resultado}");
            Console.WriteLine("Tecle enter para voltar ao menu.");
            Console.ReadLine();
            Console.Clear();
        }


    }
}
