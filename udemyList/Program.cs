using System;
using System.Collections.Generic;

namespace udemyList {
    internal class Program {
        static void Main(string[] args) {
            List<string> newList = new List<string>();
            List<string> newList2 = new List<string> { "Maria", "Alex", "Joao", "Pedro", "Antonio" };
            newList2.Add("Batata");
            //newList2.Remove("Maria"); //remove pelo elemento.
            //achando index
            Console.WriteLine(newList2.IndexOf("Maria"));
            //Removendo pelo index
            newList2.RemoveAt(newList2.IndexOf("Maria"));
            //adicionar e escolher seu index:
            newList2.Insert(2, "Jurema");

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

            //achar o primeiro nome com a letra A
            Console.WriteLine("Primeiro nome com a letra A: " + newList2.Find(Teste));
            //OU expressão lambda
            Console.WriteLine("Primeiro nome com a Letra A utilizando metodo anonimo: "+
                newList2.Find(x => x[0] == 'A'));
        }
        static bool Teste(string s) {
            return s[0] == 'A';
        }
    }
}
