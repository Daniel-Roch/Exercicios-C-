using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udemyClass {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int qtd) {
            Quantidade += qtd;
        }
        public void RemoverProdutos(int qtd) {
            Quantidade -= qtd;
        }
        public override string ToString() {
            return $"Dados do Produto - Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}, Total: {ValorTotalEmEstoque()}";
        }
    }
}
