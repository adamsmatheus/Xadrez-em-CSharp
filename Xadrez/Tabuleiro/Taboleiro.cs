using System;
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
    }
}
