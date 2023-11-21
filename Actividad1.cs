
using System;
using System.Collections;



class Actividad1
{
    static void Main()
    {
        ArrayList lista = new ArrayList() { 5, 2, 8, 1, 3 };
        Console.WriteLine("Lista sin ordenar:");
        foreach (var elemento in lista)
        {
            Console.Write(elemento + " ");
        }

        BubbleSort(lista);

        Console.WriteLine("\nLista ordenada:");
        foreach (var elemento in lista)
        {
            Console.Write(elemento + " ");
        }
    }

    static void BubbleSort(ArrayList lista)
    {
        int n = lista.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((int)lista[j] > (int)lista[j + 1])
                {
                    int temp = (int)lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
    }
}
