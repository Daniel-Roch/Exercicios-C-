using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioUdemy {
    internal class RadioClass {
        private string _nome;
        private string _musica;
        #region "class Constructor"
        public RadioClass(string nome, string musica) {
            _nome = nome;
            _musica = musica;
        }
        #endregion
        public string Musica {
            get { return _musica; }
            set { _musica = value; }
        }
    }
}
