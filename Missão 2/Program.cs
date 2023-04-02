// Missão 2:

using System.Net.Http.Headers;

int[,] matriz = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Digite os números da {i + 1}ª linha separados por um espaço: ");
    string[] vetor = Console.ReadLine().Split(' ');

    for (int j = 0; j < 3; j++)
    {
        matriz[i, j] = int.Parse(vetor[j]);
    }
}

Console.WriteLine("Matriz criada:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"| {matriz[i, j]} |");
    }

    Console.WriteLine();
}

double media1 = (matriz[0, 0] + matriz[1,0] + matriz[2, 0]) / 3;
double media2 = (matriz[0, 1] + matriz[1, 1] + matriz[2, 1]) / 3;
double media3 = (matriz[0, 2] + matriz[1, 2] + matriz[2, 2]) / 3;


Console.WriteLine("A média da coluna 1 é: " + media1);
Console.WriteLine("A média da coluna 2 é: " + media2);
Console.WriteLine("A média da coluna 3 é: " + media3);

//Abaixo a forma que eu ainda tenho que corrigir (armazenar a média em um vetor)
//string[] vetor2 = new string[3];

//vetor2[0] = double.Parse(media1[0]);
//vetor2[1] = media2;
//vetor2[3] = double.Parse(media3);

//for (int i = 0; i < 3; i++)
//{
//    Console.Write(vetor2[i]);
//}



Console.ReadLine();
