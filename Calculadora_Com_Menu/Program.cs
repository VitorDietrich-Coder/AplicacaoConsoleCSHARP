using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Com_Menu
{
    class Program
    {
        enum Menun { soma = 1, subtracao, divisao, multiplicacao, raiz, potencia,  menu,  sair };
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem-vindo a calculadora inteligente, escolha uma das opções");
                Console.WriteLine("1-Soma\n2-subtração\n3-Divisão\n4-Multiplicação\n5-Raiz\n6-Potencia\n7-Menu\n8-Sair");
                Menun opcoes = (Menun)int.Parse(Console.ReadLine());

                switch (opcoes)
                {
                    case Menun.soma:
                        soma();
                        break;
                    case Menun.subtracao:
                        subtracao();
                        break;
                    case Menun.divisao:
                        divisao();
                        break;
                    case Menun.multiplicacao:
                        multiplicacao();
                        break;
                    case Menun.raiz:
                        raiz();
                        break;
                    case Menun.potencia:
                        potencia();
                        break;
                    case Menun.sair:
                        escolheuSair = true;
                        break;
                }
                Console.WriteLine(opcoes);
                Console.Clear();
            }
        }
        static void soma() 
        {
            Console.WriteLine("Soma de dois números ");
            Console.WriteLine("Digite o primeiro número");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int valor2 = int.Parse(Console.ReadLine());
            int resultado = valor1 + valor2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Tecle qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
        static void subtracao() 
        {
            Console.WriteLine("subtracao de dois números ");
            Console.WriteLine("Digite o primeiro número");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int valor2 = int.Parse(Console.ReadLine());
            int resultado = valor1 - valor2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Tecle qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
        static void divisao()
        {
            Console.WriteLine("divisão de dois números ");
            Console.WriteLine("Digite o primeiro número");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int valor2 = int.Parse(Console.ReadLine());
            int resultado = valor1 / valor2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Tecle qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
        static void multiplicacao()
        {
            Console.WriteLine("multiplicação de dois números ");
            Console.WriteLine("Digite o primeiro número");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int valor2 = int.Parse(Console.ReadLine());
            int resultado = valor1 * valor2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Tecle qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
        static void raiz()
        {
            Console.WriteLine("Indique um núermo e veja sua raiz ");
            Console.WriteLine("Digite o  número");
            double valor1 = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(valor1);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Tecle qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
        static void potencia()
        {
            Console.WriteLine("Indique um número e seu expoente ");
            Console.WriteLine("Digite o número");
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente número");
            double Expo = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(Base, Expo);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Tecle qualquer tecla para voltar ao menu");
            Console.ReadLine();
        }
    }
}
