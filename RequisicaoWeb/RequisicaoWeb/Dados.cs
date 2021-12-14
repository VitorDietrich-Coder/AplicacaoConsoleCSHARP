using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoWeb
{
    internal class Dados
    {
        public int Userid;
        public int id;
        public string title;
        public bool completed;


        public void Exibir() 
        {
            Console.WriteLine($"User: {Userid}");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"titúlo: {title}");
            Console.WriteLine($"status: {completed}");

        }
    }
}
