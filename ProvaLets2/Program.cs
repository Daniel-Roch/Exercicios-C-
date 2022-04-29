using System;
using System.Collections.Generic;

namespace ProvaLets2 {
    internal class Program {
        static void Main(string[] args) {

            List<Motorista> listaMotoristas = new List<Motorista>();

            for (int i = 0; i < 3; i++) {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.TryParse(Console.ReadLine(), out idade) ? idade : throw new("Informe um inteiro!");
                bool carteiraDeMotorista = false;

                //Maior de 18 se tem carteira de motorista.
                if(idade > 18) {
                    Console.WriteLine("Tem carteira de motorista?");
                    string respostaCarteira = Console.ReadLine();
                    carteiraDeMotorista = respostaCarteira == "Sim" || respostaCarteira == "sim";
                }

                listaMotoristas.Add(new Motorista(nome, idade, carteiraDeMotorista));
            }

            //Precisa de 2 motoristas - 0 de 15
            List<Motorista> lista2Motoristas = new List<Motorista>();
            int countMotorista = 1;

            while (countMotorista <= 2) {
                int numAleatorio = NumAleatorio(0, 3);
                if (listaMotoristas[numAleatorio].CarteiraDeMotorista) {
                    lista2Motoristas.Add(listaMotoristas[numAleatorio]);
                    countMotorista++;
                }
            }

            //Nome do motorista - E também se caso não exista.
            string nome2Motoristas = "O nome dos motoristas são:";
            if (lista2Motoristas.Count == 2) {
                foreach (Motorista motorista in lista2Motoristas) {
                    nome2Motoristas += $" {motorista.Nome}";
                }
            }
            else {
                Console.WriteLine("viagem não será realizada devido falta de motoristas.");
            }

            Console.WriteLine(nome2Motoristas);
        }
        static int NumAleatorio(int menor, int maior) {
            Random randNum = new Random();
            return randNum.Next(menor, maior);
        }
    }
}
