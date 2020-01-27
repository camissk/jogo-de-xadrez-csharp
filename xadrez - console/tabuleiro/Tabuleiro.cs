namespace tabuleiro
{
    class Tabuleiro
    {
        //props
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        //construtor, criar tabulero e instanciar a matriz de peças e definir a quantidade de linhas e colunas 
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        } //ok
    }
}
