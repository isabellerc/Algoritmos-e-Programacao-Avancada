using System.Globalization;

string[,] matriz = new string[6, 6];

matriz[0, 0] = "gato";
matriz[0, 1] = "livro";
matriz[0, 2] = "blusa";
matriz[0, 3] = "carteira";
matriz[0, 4] = "espião";
matriz[0, 5] = "luz";
matriz[1, 0] = "espelho";
matriz[1, 1] = "blusa";
matriz[1, 2] = "escova";
matriz[1, 3] = "leão";
matriz[1, 4] = "dado";
matriz[1, 5] = "lápis";
matriz[2, 0] = "óculos";
matriz[2, 1] = "pato";
matriz[2, 2] = "carteira";
matriz[2, 3] = "lama";
matriz[2, 4] = "gato";
matriz[2, 5] = "dado";
matriz[3, 0] = "índio";
matriz[3, 1] = "luz";
matriz[3, 2] = "espelho";
matriz[3, 3] = "lama";
matriz[3, 4] = "lápis";
matriz[3, 5] = "livro";
matriz[4, 0] = "pato";
matriz[4, 1] = "espião";
matriz[4, 2] = "azul";
matriz[4, 3] = "carne";
matriz[4, 4] = "escova";
matriz[4, 5] = "vinho";
matriz[5, 0] = "leão";
matriz[5, 1] = "carne";
matriz[5, 2] = "vinho";
matriz[5, 3] = "índio";
matriz[5, 4] = "óculos";
matriz[5, 5] = "azul";


Console.WriteLine("Aqui está a disposição das cartas:");

for(int i = 0; i < 6; i++) 
{
    for(int j = 0;j<6;j++) 
    { 
        Console.Write( $" |{matriz[i,j]}| ");
    }
        Console.WriteLine();
}



Console.Write("Aperte 1 para iniciar o jogo: ");
Console.ReadLine();

Console.Write("Digite o nº da linha e coluna respectivamente para virar uma carta: ");
int carta = int.Parse(Console.ReadLine());

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write($" |{matriz[i, j]}| ");
        if (matriz[i, j] == carta)
        {

        }
    }
    Console.WriteLine();

    
}
