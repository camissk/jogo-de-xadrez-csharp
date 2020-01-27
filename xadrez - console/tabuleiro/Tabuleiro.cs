using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        //props
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //construtor, criar tabulero e instanciar a matriz de peças e definir a quantidade de linhas e colunas 
        public Tabuleiro(int linha, int coluna)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];

        }
    }
}
