using System;
using System.Collections.Generic;

namespace udemyList {
    internal class Program {
        static void Main(string[] args) {
            List<string> newList = new List<string>();
            List<string> newList2 = new List<string> { "Maria", "Alex", "Joao" };
            newList2.Add("Batata");
            //newList2.Remove("Maria"); //remove pelo elemento.
            //achando index
            Console.WriteLine(newList2.IndexOf("Maria"));
            //Removendo pelo index
            newList2.RemoveAt(newList2.IndexOf("Maria"));

            foreach(string key in newList2) {
                Console.WriteLine(key);
            }

            Dictionary<string, string> newDictionary = new Dictionary<string, string>();
            newDictionary.Add("Joao", "1234");
            newDictionary.Add("Maria", "4321");

            Console.WriteLine(newList2[2]);
            Console.WriteLine(newDictionary["Maria"]);

            foreach (string key in newDictionary.Keys) {
                Console.WriteLine(newDictionary[key]);
            }


        }
    }
}
