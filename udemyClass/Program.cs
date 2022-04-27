using System;
using System.Globalization;

namespace udemyClass {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter os dados do produto: ");
            double precoProduto;
            int qtd;

            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();
            
            Console.Write("Preço: ");
            bool validBool = true;
            
            do {
                if (!double.TryParse(Console.ReadLine(), out precoProduto)) {
                    Console.WriteLine("Você digitou o preço errado! Digite novamente.");
                    validBool = true;
                }
                else {
                    validBool = false;
                }
            } while (validBool);

            validBool = true;

            Console.Write("Quantidade: ");
            do {
                if (!int.TryParse(Console.ReadLine(), out qtd)) {
                    Console.WriteLine("Você digitou a quantidade inválida! Digite novamente.");
                    validBool = true;
                }
                else {
                    validBool = false;
                }
            } while (validBool);

            Produto produto = new Produto(nomeProduto, precoProduto, qtd);

            Console.WriteLine($"PREÇOOOO: {produto.Preco}");
            Console.WriteLine($"QUANTIDADE!: {produto.Quantidade}");
            Console.WriteLine(produto);
        }
    }
}
