using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program { 
    
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);
            tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(2,5));
            tab.colocarPeca(new Torre(tab, Cor.Preta),new Posicao(4,5));
            tab.colocarPeca(new Rei(tab, Cor.Preta) , new Posicao(5, 3));


            Tela.imprimirTabuleiro(tab);

        }
    
    }
}