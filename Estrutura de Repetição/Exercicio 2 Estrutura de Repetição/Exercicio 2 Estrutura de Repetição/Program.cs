using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_Estrutura_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aperte uma tecla para mostrar o conta giro do seu carro");
            Console.ReadLine();
            contador();
        }
        static void contador() 
        {
            int index;
            
            for (index = 0; index < 201; index++) 
            {
               
                Console.WriteLine(index + " KM/H");
              
            }
            Console.WriteLine("seu carro chegou no limite da pista de 200 KM/H");
            Console.ReadLine();
        } 
       

    }
}
