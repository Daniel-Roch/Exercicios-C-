using System;

namespace ProjetoLetsCode3 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual valor para o saque? ");
            int notaSaque = int.Parse(Console.ReadLine());

            int[] notas = new int[6];

            double diminuirNota = 0;

            if(notaSaque >= 100) {
                double result100 = 0;
                result100 = notaSaque / 100;

                notas[0] = (int) Math.Round(result100);

                diminuirNota = notaSaque - (result100 * 100);
            }
            else {
                diminuirNota = notaSaque;
            }
            if (diminuirNota >= 50) {
                notas[1] = 1;
                diminuirNota -= 50;
            }
            if (diminuirNota >= 40) {
                notas[2] = 2;
                diminuirNota -= 40;
            }
            if (diminuirNota >= 30) {
                notas[2] = 1;
                diminuirNota -= 20;
            }
            if (diminuirNota >= 20) {
                notas[2] = 1;
                diminuirNota -= 20;
            }
            if (diminuirNota >= 10) {
                notas[3] = 1;
                diminuirNota -= 10;
            }
            if (diminuirNota >= 8) {
                notas[5] = 4;
                diminuirNota -= 8;
            }
            if (diminuirNota >= 5) {
                notas[4] = 1;
                diminuirNota -= 5;
            }
            if (diminuirNota >= 4) {
                notas[5] = 2;
                diminuirNota -= 4;
            }
            if (diminuirNota >= 2) {
                notas[5] = 1;
                diminuirNota -= 2;
            }

            Console.WriteLine(
                $"{notas[0]} de 100\n" +
                $"{notas[1]} de 50\n" +
                $"{notas[2]} de 20\n" +
                $"{notas[3]} de 10\n" +
                $"{notas[4]} de 5\n" +
                $"{notas[5]} de 2\n");
        }
    }
}
