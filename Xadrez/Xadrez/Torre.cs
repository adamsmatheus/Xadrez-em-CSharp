using System;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    public class Torre : Peca
    {

        public Torre(Taboleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }

}

