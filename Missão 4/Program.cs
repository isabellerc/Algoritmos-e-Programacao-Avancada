// Missão 4: OK

int[,] A = new int[3, 3];
int[,] B = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Número da linha {i + 1} e coluna {j + 1}: ");
        A[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Formando a matriz B: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Número da linha {i + 1} e coluna {j + 1}: ");
        B[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Essa é a matriz contendo a soma das matrizes de A e B:");
int[,] C = new int[3, 3];
int soma = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        C[i, j] = A[i, j] + B[i, j];
        Console.Write($"| {C[i, j]} |");
    }
    Console.WriteLine();
}

Console.ReadLine();
