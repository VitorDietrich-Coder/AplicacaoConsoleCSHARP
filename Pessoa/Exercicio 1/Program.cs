using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            maisVelho();
        }

        public static  void maisVelho()
        {
           
            Console.WriteLine("nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("idade:");
            int idade = int.Parse( Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, idade);

            Console.WriteLine("nome:");
            string nome2 = Console.ReadLine();
            Console.WriteLine("idade:");
            int idade2 = int.Parse(Console.ReadLine());

            Pessoa pessoa2 = new Pessoa(nome, idade);

            if (idade > idade2)
            {
                Console.WriteLine("Pessoa mais velha: " + nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + nome2);
            }
            Console.ReadLine();

        }
    }
}
