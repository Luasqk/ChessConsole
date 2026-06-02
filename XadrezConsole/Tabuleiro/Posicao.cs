using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    internal class Posicao {

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int Linha, int Coluna) {
            this.Linha = Linha;
            this.Coluna = Coluna;
        }

        public override string ToString() {
            return "Posicao: " + Linha + ", " + Coluna;
        }
    }
}
