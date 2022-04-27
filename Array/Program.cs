using System;
using System.Globalization;

namespace Array {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantas alturas irão entrar?");
            int num = int.TryParse(Console.ReadLine(), out num) ? num : 0;

            Console.WriteLine(num);
            double[] array = new double[num];
            for(int i = 0; i<array.Length; i++) {
                array[i] = double.TryParse(Console.ReadLine(), out array[i]) ? array[i] : 0;
            }
            
        }
    }
}
