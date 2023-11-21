
using System;

class Actividad2
{
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.Write("La suma de todos los bordes de la matriz es: ");
        Console.WriteLine(SumBorders(matriz));
    }

    public static int SumBorders(int[,] matriz)
    {
        int resultado = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            resultado += matriz[i, 0];
            resultado += matriz[i, matriz.GetLength(1) - 1];
        }

        for (int i = 1; i < matriz.GetLength(1) - 1; i++)
        {
            resultado += matriz[0, i];
            resultado += matriz[matriz.GetLength(0) - 1, i];
        }

        return resultado;
    }
}
