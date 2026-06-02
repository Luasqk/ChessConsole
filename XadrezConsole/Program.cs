using tabuleiro;

namespace Main {
    internal class Program {
        public static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);
            Tela tela = new Tela();
            tela.imprimeTabuleiro(tab);


        }
    }
}