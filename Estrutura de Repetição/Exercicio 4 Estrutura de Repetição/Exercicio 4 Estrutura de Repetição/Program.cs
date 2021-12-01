using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4_Estrutura_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CardapioPizza();

        }
        static void CardapioPizza()
        {
            Boolean valor1 = false;
            string[] sabores = new string[9] { "calabresa", "margerita", "lombo", "queijo", "4 queijos", "Strongonoff de carne", "frango com catupiri", "palmito", "confette" };
          

                Console.WriteLine("olá meu caro segue os sabores de pizza:");

            foreach (string sabor in sabores) 
            {
                Console.WriteLine("Temos os sabores: " + sabor);
            }
            Console.ReadLine();
            Console.WriteLine("Selecione um sabor meu caro:");

            string saborcliente = Console.ReadLine();
          
            switch (saborcliente) 
            {
                case "calabresa":
                    Console.WriteLine("Você escolheu calabresa, bom apetite");
                    break;
                case "margerita":
                    Console.WriteLine("Você escolheu margerita");
                    break;
                case "lombo":
                    Console.WriteLine("Você escolheu lombo");
                    break;
                case "queijo":
                    Console.WriteLine("Você escolheu queijo");
                    break;
                case "4 queijos":
                    Console.WriteLine("Você escolheu 4 queijos");
                    break;
                case "Strongonoff de carne":
                    Console.WriteLine("Você escolheu Strongonoff de carne");
                    break;
                case "frango com catupiri":
                    Console.WriteLine("Você escolheu frango com catupiri");
                    break;
                case "palmito":
                    Console.WriteLine("Você escolheu palmito");

                    break;
                case "confette":
                    Console.WriteLine("Você escolheu confette");
                    break;

                default:
                    Console.WriteLine("escolha o sabor do cardápio");
                    break;
            }
            Console.ReadLine();
        }
    }
}