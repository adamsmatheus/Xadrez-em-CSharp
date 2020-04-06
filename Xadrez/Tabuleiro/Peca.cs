using System;
using Tabuleiro;

namespace Xadrez.Tabuleiro
{
    public class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Taboleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Taboleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public Peca()
        {
        }
    }
}
