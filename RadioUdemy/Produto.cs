using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioUdemy {
    internal class Produto {
        //Auto Properties
        public string _name;
        public double Preco { get; private set; }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public Produto(string name, double preco){
            Name = name;
            Preco = preco;
        }

        public override string ToString() {
            return $"Nome do produto: {Name}, Preço do produto: R${Preco}";
        }
    }
}
