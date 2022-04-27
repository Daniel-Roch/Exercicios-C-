using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2 {
    internal class Triangulo {
        public double A;
        public double B;
        public double C;
        public double Area(){
            double p = (this.A + this.B + this.C) / 2.0;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }
    }
}
