using System;

namespace PensaoUdemy {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int n = int.TryParse(Console.ReadLine(), out n) && n < 10 ? n : 0;

            Room[] rent = new Room[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int nRoom = int.TryParse(Console.ReadLine(), out nRoom) && nRoom < 10 ? nRoom : 0;

                while (rent[nRoom] != null) {
                    Console.WriteLine("Room occupied, please provide another room");
                    Console.Write("Room: ");
                    int newRoom = int.TryParse(Console.ReadLine(), out newRoom) && newRoom > 10 ? newRoom : 0;
                    nRoom = newRoom;
                }
                //Sem o construtor eu faria: rent[nRoom] = new Room { Name = name, Email = email };
                rent[nRoom] = new Room(name, email);
            }
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (rent[i] != null) {
                    Console.WriteLine($"{i}: {rent[i]}"); 
                }
                else {
                    continue;
                }
            }
        }
    }
}
