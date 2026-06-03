using tabuleiro;

namespace xadrez {
    internal class Cavalo : Peca {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "C";
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima e Esquerda
            pos.definirValores(posicao.linha - 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Acima e Direita
            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Direita e Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Direita e Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Abaixo e Direita
            pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Abaixo e Esquerda
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Esquerda e Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //Esquerda e Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}