using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySalary {
    internal class User {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public User(int id, string name, double salary) {
            Id = id; 
            Name = name; 
            Salary = salary;
        }
        public void increaseSalary(double percentagem) {
            Salary += Salary * percentagem / 100.00;
        }
        public override string ToString() {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
