using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaSoma {
    internal class Calculadora {
        //params -> irá servir para eu conseguir criar sem precisar do new int[]..
        // basta criar desta forma: Calculadora.Sum(1,2,3,4)
        public static int Sum(params int[] numbers) {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++) { 
                result += numbers[i];
            }
            return result;
        }
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }
}
