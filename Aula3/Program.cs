//Declaração da biblioteca
using System;
//Declaração do namespace do meu programa
namespace Aula3 {
    //Declaração da minha classe
    class Program {
        //Isso é uma função - ponto de entrada. a principal void
        static void Main(string[] args) {
            Console.Write("Digite três números (ex: 1 2 3) : ");
            string inputUsu = Console.ReadLine();

            string[] inputsArray = inputUsu.Split(' ');
            int[] numArray = new int[inputsArray.Length];

            for (int i = 0; i < inputsArray.Length; i++) {
                int numInvit = int.Parse(inputsArray[i]);
                numArray[i] = numInvit;
            }

            //GetType saber o que é - System.int32... typeof(int) saber se é inteiro
            //Console.WriteLine(numArray[2].GetType() == typeof(int));
            Console.WriteLine(Maior(1, 2, 3));
        }
        //criando uma função: - Lembre-se Static é algo de classe que não precisa instanciar, basta chamar
        static int Maior(int a, int b, int c) {
            Console.WriteLine("Maior em");
            return 1;
        }
    }
}