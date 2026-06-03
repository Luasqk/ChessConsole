using System;
using tabuleiro;
using xadrez;

namespace xadrez_Console {
    internal class Program {
        public static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {

                    Console.Clear();
                    Tela.imprimeTabuleiro(partida.tab);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}