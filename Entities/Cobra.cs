using System;
using Snake.Enums;
using Snake.Exceptions;
namespace Snake.Entities
{
    public sealed class Cobra : Corpo
    {
        public Direcao Direcao { get; set; }
        public Cobra(Posicao posicao)
        {
            TipoDeEntidades = TipoDeEntidades.Cobra;
            Posicao = posicao;
        }
    }
}
