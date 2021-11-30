using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Funcões
{
    class Program
    {
        static void Main(string[] args)
        {
           double AreaResult =  AreaTriangulo(250 , 350);
            Console.WriteLine(AreaResult);
            Console.ReadLine();
        }
        static double AreaTriangulo(double Base, double Altura)
        {
            double Area = 0;

            Area = (Base + Altura) / 2;
            

            return Area;
        }
    }
}
