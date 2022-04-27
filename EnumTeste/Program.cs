using System;

namespace enumTeste {
    class Program {
        enum DiaSemana {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }
        static void Main(string[] args) {
            //par colocar o Indice, preciso fazer o casting
            DiaSemana ds = (DiaSemana) 3;
            Console.WriteLine(ds);
        }
    }
}