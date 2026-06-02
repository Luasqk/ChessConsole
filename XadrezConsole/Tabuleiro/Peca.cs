    using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    internal class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int QnteMovimento { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            QnteMovimento = 0;
        }
    }
}
