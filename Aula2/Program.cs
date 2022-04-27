using System;

namespace Aula2 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Bem-vindo(a)!");
            //Console.Write("Digite um número: ");
            //string inputUsu = Console.ReadLine();
            //int num;
            //if (!int.TryParse(inputUsu, out num)) {
            //    Console.WriteLine("Você não digitou um número!");
            //    //Sem o return a aplicação não para.
            //    return;
            //}
            //Console.WriteLine("BOA!");
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            Console.WriteLine(areaX);
        }
    }
}