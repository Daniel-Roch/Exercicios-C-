using System;
using System.Globalization;

namespace letsCodeEx3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bem-vindo(a)!");

            double salary;
            bool validBool = true;
            double discountINSS = 0;

            Console.Write("Digite seu salário: ");

            do {
                if (!double.TryParse(Console.ReadLine(), out salary)) {
                    Console.WriteLine("Você digitou errado, Digite novamente!");
                }
                else {
                    validBool = false;
                }

            } while (validBool);

            if (salary <= 1212)
                discountINSS = salary * 0.075;

            else if (salary > 1212 & salary <= 2427.35) {
                discountINSS = (1212 * 0.075) + ((salary - 1212) * 0.09);

            }
            else if (salary > 2427.35 & salary <= 3641.03) {
                discountINSS = (1212 * 0.075) + ((2427.35 - 1212) * 0.09) + ((salary - 2427.35) * 0.12);
            }
            else if (salary > 3641.03 && salary <= 7087.22) {
                discountINSS = (1212 * 0.075) + ((2427.35 - 1212) * 0.09) + ((3641.03 - 2427.35) * 0.12) + ((salary - 3641.03) * 0.14);
            }
            else {
                discountINSS = (1212 * 0.075) + ((2427.35 - 1212) * 0.09) + ((3641.03 - 2427.35) * 0.12) + ((7087.22 - 3641.03) * 0.14);
            }

            Console.WriteLine($"Seu desconto do INSS é de: R$ {discountINSS.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}