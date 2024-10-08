﻿using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei( Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

            }
            //NE
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Direita
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Sudeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Abaixo
            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Sudoeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Nordeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;




        }
    }
}
