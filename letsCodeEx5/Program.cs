using System;

namespace letsCodeEx5 {
    internal class Program {
        static void Main(string[] args) {
            int count = 0;
            bool password = false;

            Console.WriteLine("Bem-vindo(a)!, Digite uma senha de 4 dígitos: exemplo: 1 2 3 4 --");
            Console.Write("Senha: ");
            string inputPassword;
            int[] arrayPassword = new int[4];

            while (!password) {
                if(count == 3) {
                    Console.Clear();
                    Console.WriteLine("---------- Senha Bloqueada! ----------");
                    break;
                }

                inputPassword = Console.ReadLine();

                if (inputPassword == "" || inputPassword.Split(' ').Length != 4) {
                    Console.WriteLine("Senha Incorreta");
                    Console.WriteLine("--------------------");
                    Console.Write("Tenta Novamento: ");
                    count++;
                }
                else {
                    for (int i = 0; i < inputPassword.Split(' ').Length; i++) {
                        arrayPassword[i] = int.TryParse(inputPassword.Split(' ')[i], out arrayPassword[i])? arrayPassword[i] : throw new("Informe um inteiro!");
                    }
                    if(arrayPassword[0] == 5 && arrayPassword[1] == 1 && arrayPassword[2] == 9 && arrayPassword[3] == 0) {
                        Console.WriteLine("Senha Correta! ");
                        password = true;
                    }
                    else {
                        Console.WriteLine("Senha Incorreta");
                        Console.WriteLine("--------------------");
                        Console.Write("Tenta Novamento: ");
                        count++;
                    }

                }

            }
        }
    }
}
