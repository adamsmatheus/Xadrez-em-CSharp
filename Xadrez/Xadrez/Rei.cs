using System;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    public class Rei : Peca
    {


        public Rei(Taboleiro tab, Cor cor) : base(tab,cor) 
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
