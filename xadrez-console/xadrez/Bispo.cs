using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "B";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }


        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Noroeste linha -1, coluna -1
            pos.DefinirPosicao(posicao.Linha - 1, posicao.Coluna - 1);
            while (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirPosicao(posicao.Linha - 1, posicao.Coluna - 1);

            }

            //Nordeste linha -1, coluna + 1
            pos.DefinirPosicao(posicao.Linha -1 , posicao.Coluna + 1);
            while(tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirPosicao(posicao.Linha - 1, posicao.Coluna + 1);
            }

            //Sudeste Linha +1, coluna + 1
            pos.DefinirPosicao(posicao.Linha + 1, posicao.Coluna + 1);
            while(tab.PosicaoValida(pos) && PodeMover(pos) )
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor )
                {
                    break;
                }
                pos.DefinirPosicao(posicao.Linha + 1, posicao.Coluna + 1);
            }

            //Sudoeste linha + 1, coluna - 1
            pos.DefinirPosicao(posicao.Linha + 1, posicao.Coluna - 1);
            while(tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;  
                }
                pos.DefinirPosicao(posicao.Linha + 1, posicao.Coluna - 1);
            }

            return mat;
        }

       
    }
}
