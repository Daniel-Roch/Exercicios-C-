using System;

namespace ProvaLetsCode {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Preciso que você compre 4 caixas de leite, se tiver ovos traga 6.");

            bool sol = true;
            bool estacCoberto = true;
            bool carteira = true;

            if (carteira) {

                if (sol || estacCoberto) {
                    Console.Write("Quantos ovos tem? ");
                    int qtaOvos = int.TryParse(Console.ReadLine(), out qtaOvos) ? qtaOvos : throw new("Informe um inteiro!");


                    int leite = 0;
                    int ovos = 0;

                    double precoLeite = 3.15;
                    double precoOvo = 0.58;

                    double totalCompra = 0;

                    if (qtaOvos > 0) {
                        //O que ele levou.
                        Console.WriteLine($"Tome 6 caixas de leite");

                        //O que ele deveria levar
                        leite = 4;
                        ovos = 6;

                        totalCompra = ((leite * precoLeite) + (ovos * precoOvo));

                        //Se a dúzia for menor que R$ 6,00.
                        Console.WriteLine("Qual o preço da dúzia?");
                        double novoPrecoOvo = double.TryParse(Console.ReadLine(), out novoPrecoOvo) ? novoPrecoOvo : throw new("Informe um double!");
                        precoOvo = novoPrecoOvo / 12;

                        if ((precoOvo * 12) < 6.00) {

                            totalCompra = ((leite * precoLeite) + (ovos * precoOvo));
                        }
                        else {
                            ovos = 0;
                            totalCompra = ((leite * precoLeite) + (ovos * precoOvo));
                        }
                    }
                    else {
                        //caso não tenha ovos
                        leite += 4;
                        totalCompra = ((leite * precoLeite));

                        Console.WriteLine($"Tome 4 caixas de leite");
                    }
                }
            }
            else {
                Console.WriteLine("Fiado de forma alguma, vá para casa espertão");
            }
        }
    }
}
