using Snake.Enums;
namespace Snake.Entities
{
    public abstract class Corpo
    {
        public TipoDeEntidades TipoDeEntidades { get; set; }
        public Posicao Posicao { get; set; }
    }
}
