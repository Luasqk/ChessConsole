using System;
using tabuleiro;
using xadrez;

namespace xadrez_Console {
    internal class Program {
        public static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {

                    try {
                        Tela.imprimirPartida(partida);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimeTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("\nDestino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);

                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Pressione enter para tentar novamente ...");
                        Console.ReadLine();
                    }
                }
                Tela.imprimirPartida(partida);
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}