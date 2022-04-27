using System;

namespace CalculaSoma {
    internal class Program {
        static void Main(string[] args) {
            //Sem o Params - int resultSoma = Calculadora.Sum(new int[] { 1, 3, 4});
            int resultSoma = Calculadora.Sum( 1, 3, 4);
            Console.WriteLine(resultSoma);

            //se não fosse o ref, o y continuaria 10.. porém ele foi alterado agora.
            int y = 10;
            Calculadora.Triple(ref y);
            Console.WriteLine(y);
        }
    }
}
