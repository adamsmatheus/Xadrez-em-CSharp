using System;
using Tabuleiro;

namespace Xadrez.Tabuleiro
{
    public class Taboleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        public Taboleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];


        }

        
        public Peca peca (int linha, int coluna)
        {

            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {

            return pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validaPosicao(pos);
            return peca(pos) != null;

        }
        public void colocarPeca (Peca p , Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça!");

            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }
        public bool posicaoValida(Posicao pos)
        {

            if(pos.Linha<0 || pos.Linha >= linhas || pos.Coluna <0 || pos.Coluna >= colunas)
            {
                return false;
            }
            return true;

        }

        public void validaPosicao(Posicao pos)
        {

            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");

            }
        }

       
    }
}
