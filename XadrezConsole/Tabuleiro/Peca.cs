using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int QnteMovimento { get; protected set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            QnteMovimento = 0;
        }

        public void incrementaQnteMovimento() {
            QnteMovimento++;
        }

        public void decrementaQnteMovimento() {
            QnteMovimento--;
        }

        public bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public abstract bool[,] movimentosPossiveis();
        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true; // Se achar pelo menos um 'true', a peça não está presa
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

    }
}
