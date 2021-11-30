using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Funções
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Segue preços dos produtos com aumento de 25%");
            PrecoFinal(); 
            Console.ReadLine();
        }

        static void PrecoFinal()
        {
            double chocolate = 30, refrigerante = 50, bolo = 15, sorvete = 10, pao = 25 ;
            double produtos;
            double porcent = 0.25; 
            double resultadofim;
            int i;

            double[] umAoCinco =  new double[5] { chocolate, refrigerante, bolo, sorvete, pao };
           
            for ( i = 0; i <  umAoCinco.Length ; i++)
            {

                produtos = porcent * umAoCinco[i];
                resultadofim = produtos + umAoCinco[i];
                Console.WriteLine( resultadofim);
            }
            Console.ReadLine();

        }
    }
}
