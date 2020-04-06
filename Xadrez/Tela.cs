using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    public class Tela
    {


        public Tela()
        {
        }

        public static void imprimirTabuleiro(Taboleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("-");

                    }
                Console.Write(tab.peca(i, j) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
