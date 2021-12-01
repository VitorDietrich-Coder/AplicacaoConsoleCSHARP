using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_Estrutura_de_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            HorarioFunciona();
        }
        static void HorarioFunciona() 
        {
            Console.WriteLine("digite um horário para ver se o estabelecimento está aberto.");
                int recebehorario =  int.Parse(Console.ReadLine());

            if (recebehorario < 17 && recebehorario > 7)
            {
                Console.WriteLine("O estabelecimento está em horário de atendimento até as 17H");

            }
            else 
            {
                Console.WriteLine("O estabelecimento está fechado, horarário de atendimento das 7h as 17h");

            }
            Console.ReadLine();
        }
    }
}
