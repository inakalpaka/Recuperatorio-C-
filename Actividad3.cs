
using System;

class Actividad3
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.Write("La suma de las diagonales de la matriz es: ");
        Console.WriteLine(SumDiagonals(matriz));
    }

    public static int SumDiagonals(int[,] matriz)
    {
        int resultado = 0;
        bool p = true;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int e = 0; e < matriz.GetLength(1); e++)
            {
                if (p)
                {
                    if (e % 2 == 0)
                    {
                        resultado = resultado + matriz[e, i];
                    }
                }
                else
                {
                    if (!(e % 2 == 0))
                    {
                        resultado = resultado + matriz[e, i];
                    }
                }
            }
            if (p)
            {
                p = false;
            }
            else
            {
                p = true;
            }
        }
        return resultado;
    }
}
