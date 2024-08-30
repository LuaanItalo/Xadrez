using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    internal class PosicaoXadrez
    {
        public char coluna { get; set; }

        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linhs)
        {
            this.coluna = coluna;
            this.linha = linhs;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;

        }

    }
}
