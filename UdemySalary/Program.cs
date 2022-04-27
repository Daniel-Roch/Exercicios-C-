using System;
using System.Collections.Generic;

namespace UdemySalary {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int nEmployees = int.TryParse(Console.ReadLine(), out nEmployees) ? nEmployees : throw new("Informe um inteiro!");

            List<User> listUsers = new List<User>();

            for (int i = 1; i <= nEmployees; i++) {
                Console.WriteLine($"Emplyoee #{i}");

                Console.Write("Id: ");
                int idUser = int.TryParse(Console.ReadLine(), out idUser) ? idUser : throw new("Informe um inteiro!");

                Console.Write("Name: ");
                string nameUser = Console.ReadLine();

                Console.Write("Salary: ");
                double salaryUser = double.TryParse(Console.ReadLine(), out salaryUser) ? salaryUser : throw new("Informe um double");

                listUsers.Add(new User(idUser, nameUser, salaryUser));
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");

            int searchId = int.TryParse(Console.ReadLine(), out searchId) ? searchId : throw new("Informe um inteiro!");

            int resultSearchId = listUsers.FindIndex(x => x.Id == searchId);

            if (resultSearchId >= 0) {
                Console.Write("Enter the percentagem: ");
                double percent = double.TryParse(Console.ReadLine(), out percent) ? percent : throw new("Informe um double");
                listUsers[resultSearchId].increaseSalary(percent);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            //Mostrar todos
            foreach (User user in listUsers) {
                Console.WriteLine(user);
            }

        }
    }
}
