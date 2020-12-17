using System;
using Snake.Entities;
using System.Threading;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int cursor = 1;
        TelaInicial:
            Console.Clear();
            if (cursor == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Jogar");
                Console.ResetColor();
                Console.WriteLine("Recordes");
                Console.WriteLine("Configurações");
                Console.WriteLine("Sair");
                Console.WriteLine();
                Console.WriteLine("Iniciar partida");
            }
            if (cursor == 2)
            { 
                Console.WriteLine("Jogar");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Recordes");
                Console.ResetColor();
                Console.WriteLine("Configurações");
                Console.WriteLine("Sair");
                Console.WriteLine();
                Console.WriteLine("Visualizar os recordes de partidas anteriores(AINDA NÃO DISPONIVEL)");
            }
            if (cursor == 3)
            {

                Console.WriteLine("Jogar");

                Console.WriteLine("Recordes");
                Console.BackgroundColor = ConsoleColor.DarkRed; 
                Console.WriteLine("Configurações");
                Console.ResetColor();
                Console.WriteLine("Sair");
                Console.WriteLine();
                Console.WriteLine("Alterar as configurações(AINDA NÃO DISPONIVEL)");
            }
            if (cursor == 4)
            {
                Console.WriteLine("Jogar");
                Console.WriteLine("Recordes");
                Console.WriteLine("Configurações");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sair");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Finalizar programa");
            }
            Console.WriteLine("Utilize Enter para selecionar e as setas Cima e Baixo para mover");
            ConsoleKeyInfo Tecla = Console.ReadKey();
            if (Tecla.Key == ConsoleKey.UpArrow)
            {
                if (cursor > 1)
                {
                    cursor--;
                }
                Console.Beep();
                goto TelaInicial;
            }
            if (Tecla.Key == ConsoleKey.DownArrow)
            {
                if (cursor < 4)
                {
                    cursor++;
                }
                Console.Beep();
                goto TelaInicial;
            }
            if (Tecla.Key == ConsoleKey.Enter)
            {
                Console.Beep();
                switch (cursor)
                {

                    case 1:
                        Console.Clear();
                        Partida partida = new Partida();
                        partida.ImprimirPartida();
                        break;
                    case 4:
                        break;
                    default:
                        goto TelaInicial;
                }
            }
            else
            {
                goto TelaInicial;
            }
        }
    }
}
