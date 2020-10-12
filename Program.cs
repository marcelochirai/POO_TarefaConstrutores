using System;
using System.Globalization;

namespace POO_TarefaConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não é necessário instanciar o objeto no início
            
            Console.Write("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Qual o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Instanciação do objeto p, sem sujeiras iniciais
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.Write("Dados do atualizados: " + p);

        }
    }
}
