using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3___POO
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;
        public Curso(string nome, float preço, string autor) 
        {
            this.nome = nome;
            this.preço = preço;
            this.autor = autor;
        }

        public void adicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso : {nome}");
            Console.WriteLine("Digite a quantidade que vagas que quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();

        }
        public void adicionarSaida()
        {
            Console.WriteLine($"Dar saída nas vagas do curso: {nome}");
            Console.WriteLine("Digite a quantidade  de vagas que você quer dar saída: ");
            int saida = int.Parse(Console.ReadLine());
            vagas -= saida;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preço}");
            Console.WriteLine($"Vagas restantes: {vagas}");
           
          
        }
    }
}
