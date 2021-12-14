using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3___POO
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;
        public Ebook(string nome, float preço, string autor)
        {
            this.nome = nome;
            this.preço = preço;
            this.autor = autor;
        }

        public void adicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada no estoque do ebook, pois é um produto virtual");
            Console.ReadLine();
        }
        public void adicionarSaida()
        {
            Console.WriteLine("Não é possível dar saída no estoque do ebook, pois é um produto virtual");
            Console.ReadLine();

        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preço}");
            Console.WriteLine($"Vendas restantes: {vendas}");
        }
    }
}
