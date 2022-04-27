using System;

namespace RadioUdemy {
    class Program {
        static void Main(string[] args) {

            Produto algo = new Produto("TV", 10.35);
            algo.Name = "a";
            Console.WriteLine(algo);

        }
    }
}