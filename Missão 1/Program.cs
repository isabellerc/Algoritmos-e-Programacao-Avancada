//Missão 1:
using System.Runtime.Serialization;

int maiorElemento = int.MinValue;
int soma = 0;
int qtdPrimos = 0;


int[,] matriz = new int[3,3];

for (int i = 0; i< 3; i++)
{
    Console.Write($"Digite os números da {i+1}ª linha separados por um espaço: ");
    string[] vetor = Console.ReadLine().Split(' ');

    for (int j = 0; j < 3; j++)
    {
        matriz[i, j] = int.Parse(vetor[j]);
    }
}

Int64 idade;

Console.WriteLine("Essa é sua matriz:");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"| {matriz[i, j]} |");

        int numero = matriz[i, j];

        bool ENumeroPrimo(int numero)
        {
            int n = numero - 1;
            if (numero == 1 || numero == 2 || (numero % 2 == 0))
            {
                return false;
            }

            int resto = numero % n;
            while (resto != 0 && n > 1 )  
            {
              
                resto = numero % n;
                if (resto == 0) return false;
                n--;
            }

            return true;
        }

        if (ENumeroPrimo(matriz[i,j]))
            qtdPrimos++;

        if (matriz[i, j] > maiorElemento)
        {
            maiorElemento = matriz[i, j];
        }

        soma = matriz[i, j] + soma;
       

        

        }
    Console.WriteLine();
}

Console.WriteLine("O maior elemento é: " + maiorElemento);
Console.WriteLine("A soma dos elementos dessa matriz é: " + soma);
Console.WriteLine("A quantidade de números primos encontrados é: " + qtdPrimos);

Console.ReadLine();


