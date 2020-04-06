using System;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Taboleiro tab = new Taboleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
