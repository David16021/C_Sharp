int [,] matriz = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
Console.WriteLine("Matriz de 5x2");
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

int[][] matrizEscalonada = new int[3][];
matrizEscalonada[0] = new int[] { 1, 2 };
matrizEscalonada[1] = new int[] { 3, 4 ,5};
matrizEscalonada[2]= new int[] { 6, 7, 8, 9 };
Console.WriteLine();
Console.WriteLine("Matriz escalonada");
for (int i = 0; i < matrizEscalonada.GetLength(0); i++)
{
    for (int j = 0; j < matrizEscalonada[i].GetLength(0); j++)
    {
        Console.Write(matrizEscalonada[i][j] + " ");
    }
    Console.WriteLine();
}
