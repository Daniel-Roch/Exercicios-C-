//Class Motorista
namespace ProvaLets2 {
    internal class Motorista {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool CarteiraDeMotorista { get; set; }

        public Motorista(string nome, int idade, bool carteiraDeMotorista) { 
            Nome = nome;
            Idade = idade;
            CarteiraDeMotorista = carteiraDeMotorista;
        }

    }
}
