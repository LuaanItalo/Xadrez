
using tabuleiro;


namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            posicao = null;
            this.cor = cor;
            tab = tab;
            QteMovimentos = 0;
        }
    }
}
