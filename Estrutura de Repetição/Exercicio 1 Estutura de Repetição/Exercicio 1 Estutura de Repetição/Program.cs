using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Estutura_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            BoasVindas();
        }

        static void BoasVindas()
        {
            string[] nomes = new string[10] { "vitor", "joao", "augusto", "pedro", "vinicius",  "mayra", "josé", "marcelo", "joao pedro", "diego" };


            foreach (string nome in nomes)
            {
                Console.WriteLine("Seja Bem-Vindo: " + nome);
                
            }

            Console.ReadLine();
          
        }
    }
}
