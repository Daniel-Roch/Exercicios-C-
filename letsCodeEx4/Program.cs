using System;

namespace letsCodeEx4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bem-vindo(a)! a canção dos patinhos em pt-BR!");
            Console.Write("Quantos patinhos devemos começar? ");
            int nDucks = int.TryParse(Console.ReadLine(), out nDucks) ? nDucks : throw new ("Informe um inteiro!");
            int totalDucks = nDucks;

            while (nDucks != 0) {
                Console.WriteLine("-------------------------------\n" +
                    $" {nDucks} patinhos foram passear \n" +
                    " Além das montanhas \n" +
                    " Para brincar \n" +
                    " A mamãe gritou: Quá, quá, quá, quá \n" +
                    $" Mas só {nDucks-= 1} patinhos voltaram de lá.\n" +
                    "------------------------------- \n");
            }
            Console.WriteLine(" A mamãe patinha foi procurar \n" +
                    " Além das montanhas \n" +
                    " Na beira do mar \n" +
                    " A mamãe gritou: Quá, quá, quá, quá \n" +
                    $" E os {totalDucks} patinhos voltaram de lá.");
        }
    }
}
