using tabuleiro;

namespace xadrez {
    internal class Cavalo : Peca{
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "C";
        }
        public override bool[,] movimentosPossiveis() {
            throw new NotImplementedException();
        }
    }
}
