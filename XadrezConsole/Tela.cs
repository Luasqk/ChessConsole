using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro {
    internal class Tela {
        public void imprimeTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tab.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
