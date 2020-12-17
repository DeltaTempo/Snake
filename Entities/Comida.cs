namespace Snake.Entities
{
    public sealed class Comida : Corpo
    {
        public Comida(Posicao posicao)
        {
            Posicao = posicao;
            TipoDeEntidades = Enums.TipoDeEntidades.Comida;
        }
    }
}
