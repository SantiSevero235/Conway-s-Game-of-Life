using System;
using System.Text;

namespace Gameoflife
{

    // Esta clase tiene la responsabilidad de imprimir el tablero
    public static class ImprimirTablero
    {
        public static void Imprimir(bool[,] b)
        {
            int width = b.GetLength(0); //variabe que representa el ancho del tablero
            int height = b.GetLength(1); //variabe que representa altura del tablero
            Console.Clear();
            StringBuilder s = new StringBuilder();
            // Las iteraciones se encargan de recorrer el arreglo linea por linea
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (b[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================

        }
    }
}