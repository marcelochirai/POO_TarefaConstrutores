using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_TarefaConstrutores
{
    public class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtores - PERMITE OU OBRIGA O OBJETO RECEBER DADOS E DEPENDÊNCIAS NO MOMENTO DE SUA INSTANCIAÇÃO;
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade
            + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
