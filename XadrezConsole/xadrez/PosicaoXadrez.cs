using tabuleiro;

namespace xadrez {
    internal class PosicaoXadrez {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(int linha, char coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');

        }

        public override string ToString() {
            return "" + coluna + linha;
        }
    }
}
