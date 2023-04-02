// Missão 3: está totalmente correta

int[,] A = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Número da linha {i + 1} e coluna {j + 1}: ");
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz criada:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"| {A[i, j]} |");
    }

    Console.WriteLine();
}

Console.WriteLine("Matriz transposta:");

for (int k = 0; k < 3; k++)
{
    for (int l = 0; l < 3; l++)
    {
        Console.Write($"| {A[l, k]} |");
    }

    Console.WriteLine();
}


