namespace Snake.Entities
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Posicao(int colunas, int linhas)
        {
            Linha = linhas;
            Coluna = colunas;
        }
    }
}
