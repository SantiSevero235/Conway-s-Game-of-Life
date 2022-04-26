using System;
using System.IO;

namespace Gameoflife
{

    // Esta clase tiene la responsabilidad de crear el tablero base, con el cual se crean los demas. Este se encuentra en board.txt
    public static class Inicializador
    {
        public static bool[,] Inicio()
        {
            string url = "../../assets/board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
            return board;
        }
    }
}
