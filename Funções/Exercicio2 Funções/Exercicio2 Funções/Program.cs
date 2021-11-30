using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercicio2_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paulo é um pizzaiolo que precisa descobrir a área de uma circunferência para conseguir fazer a pizza perfeita e ganhar o concurso nacional, Crie um programa C# fazendo o uso das funções, que calcule a área de um círculo, recebendo o raio valor 30 desejado por Paulo.
            double valor = Circulo(30);
            Console.WriteLine(valor);
            Console.ReadLine();
        }

        static double Circulo(double raio) {
         
            double circuloarea = 0;
            const double pi= 3.14;
            circuloarea = raio * raio * pi;
            

            return circuloarea;
        }
    }
}
