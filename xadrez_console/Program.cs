using tabuleiro;

namespace xadrez_console {
    class Program { 
    
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);
            tab.colocarPeca( ,new Posicao(0,0));
            tab.colocarPeca( , new Posicao(5, 3));


            Tela.imprimirTabuleiro(tab);

        }
    
    }
}