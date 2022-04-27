using System;
namespace letsCodeEx2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Responda 's' ou 'n':");

            Console.Write("Telefonou para a vítima? ");
            char questionCell = Convert.ToChar(Console.ReadLine());
            Console.Write("Esteve no local do crime? ");
            char questionBeen = Convert.ToChar(Console.ReadLine());
            Console.Write("Mora perto da vítima? ");
            char questionLive = Convert.ToChar(Console.ReadLine());
            Console.Write("Devia para a vítima? ");
            char questionShould = Convert.ToChar(Console.ReadLine());
            Console.Write("Já trabalhou com a vítima? ");
            char questionJob = Convert.ToChar(Console.ReadLine());

            char[] arrayQuestions = { questionCell, questionBeen, questionLive, questionShould, questionJob };

            int questionPositive = 0;
            int questionNegative = 0;

            for (int i = 0; i < arrayQuestions.Length; i++) {
                if (arrayQuestions[i] == 's')
                    questionPositive += 1;
                else
                    questionNegative += 1;
            }

            switch (questionPositive) {
                case 2:
                    Console.WriteLine("Suspeita");
                    break;

                case 3:
                case 4:
                    Console.WriteLine("Cúmplice");
                    break;

                case 5:
                    Console.WriteLine("Assassino");
                    break;
                default:
                    Console.WriteLine("Inocente");
                    break;
            }

        }
    }
}