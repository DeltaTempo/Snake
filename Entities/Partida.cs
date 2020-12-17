using System;
namespace Snake.Entities
{
    public class Partida
    {
        public Cobra Cobra { get; set; }
        public Comida Comida { get; set; }
        Corpo[,] corpos = new Corpo[15, 17];

        public Partida()
        {
            corpos[13,8] = new Comida(new Posicao(13,8));
            for (int i = 0; i < 4; i++)
            {
                corpos[i + 3, 8] = new Cobra(new Posicao(8,i+3));
            }
        }
        public void ImprimirPartida()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (corpos[i,j] == null)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        if (corpos[i,j].TipoDeEntidades == Enums.TipoDeEntidades.Cobra)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write("   ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
