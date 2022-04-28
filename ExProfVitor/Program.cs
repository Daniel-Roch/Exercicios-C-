using System;
using System.Collections.Generic;

namespace ExProfVitor {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite os número: ");
            bool numPrimo = false;

            List<int> numbers = new List<int>();

            //Estrutura de repetição que para somente se digitar um número primo (dividido por ele mesmo)
            while (!numPrimo) {
                int divisor = 0;

                int numInput = int.TryParse(Console.ReadLine(), out numInput) ? numInput : throw new("Informe um inteiro!");
                
                //conta quantas vezes fez a divição com resto 0
                for(int i = 1; i <= numInput; i++) {
                    if (numInput % i == 0)
                        divisor++;
                }
                //saber se é ou não Primo.
                if(divisor == 2) {
                    numbers.Add(numInput);
                    numPrimo = true;
                }
                else 
                    numbers.Add(numInput);
            }

            //Exibir Par ou Impar
            string mostraPar = "Numeros pares:";
            string mostraImpar = "Numeros pares:";

            foreach (int i in numbers) {
                if(i % 2 == 0)
                    mostraPar += $" {i}";
                else
                    mostraImpar += $" {i}";
            }

            Console.WriteLine($"{mostraPar}\n{mostraImpar}");

            //Soma de todos os valores
            int somaAll = 0;
            foreach (int i in numbers) {
                somaAll += i;
            }
            Console.WriteLine($"A soma de todos os valores será: {somaAll}");

            //Retornar o menor e o maior valor
            int maiorValor = numbers[0];
            int menorValor = numbers[0];
            foreach (int i in numbers) {
                if (maiorValor < i)
                    maiorValor = i;
                if (menorValor > i)
                    menorValor = i;
            }
            Console.WriteLine($"O maior valor é: {maiorValor}\nO menor valor é: {menorValor}");

            //pegar 1/3 do total que foi entregue pelo usuário
            int qtaNumRandom = (int)Math.Round(decimal.ToDouble(numbers.Count / 3));

            //Criar uma nova lista com números aleatórios
            List<int> newListRandom = new List<int>();

            for (int i = 0; i < qtaNumRandom; i++) {
                newListRandom.Add(Random(menorValor, maiorValor));
            }
            newListRandom.Sort();

            //Criando uma copia para pegar os números iguais.
            List<int> newListRandomCopy = new List<int>();

            foreach (int numRandom in newListRandom) {
                int indexCopy = numbers.FindIndex(x => x == numRandom);
                if (indexCopy >= 0) {
                    newListRandomCopy.Add(numbers[indexCopy]);
                }
            }
            string resultRandomCopy = $"O que será exibido: Os números {String.Join(",", newListRandomCopy.ToArray())} da lista randômica estão presentes no input do usuário.";

            //Removendo o números iguais da lista numbers
            foreach (int numRandom in newListRandom) {
                int indexCopy = numbers.FindIndex(x => x == numRandom);
                if (indexCopy >= 0) {
                    numbers.RemoveAt(indexCopy);
                }
            }


            string resultFinal = "Retirando números randômicos encontrados, a sua lista de input agora é: ";

            foreach (int numFinish in numbers) {
                resultFinal += $" {numFinish}";
            }

            //Exibir quais são iguais na lista de random.
            Console.WriteLine(resultRandomCopy);
            //Exibir o resultado final da List numbers retirando os iguais de ambas as listas
            Console.WriteLine(resultFinal);
        }

        //metodo para gerar um numero randomico entre o menor e o maior.
        static int Random(int menorNum, int maiorNum) {
            Random randNum = new Random();
            return randNum.Next(menorNum, maiorNum);
        }
    }
}
