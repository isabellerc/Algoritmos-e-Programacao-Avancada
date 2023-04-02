
Console.WriteLine("1 - Iniciar novo jogo Humano vs Humano");
Console.WriteLine("2 – Iniciar novo jogo Humano vs Máquina");
Console.WriteLine("3 – Sair");
Console.WriteLine();
Console.WriteLine("Aqui está a numeração de cada posição no jogo: ");
Console.WriteLine(" ");


Console.WriteLine($"    1   |  2  |   3");
Console.WriteLine("  ------- ----- -------");
Console.WriteLine("    4   |  5  |   6");
Console.WriteLine("  ------- ----- -------");
Console.WriteLine("    7   |  8  |   9");

Console.WriteLine();

bool fimDeJogo = true;
int n1 = 0, n2 = 0;
char p1 = '1', p2 = '2', p3 = '3', p4 = '4', p5 = '5', p6 = '6', p7 = '7', p8 = '8', p9 = '9';

Console.WriteLine("Digite o valor correspondente a numeração que deseja ocupar: ");
do
{
    
    Console.Write("JOGADOR 1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine();


    switch (n1)
    {
        case 1:
            p1 = 'X';
            break;

        case 2:
            p2 = 'X';
            break;

        case 3:
            p3 = 'X';
            break;


        case 4:
            p4 = 'X';
            break;

        case 5:
            p5 = 'X';
            break;

        case 6:
            p6 = 'X';
            break;

        case 7:
            p7 = 'X';
            break;

        case 8:
            p8 = 'X';
            break;

        case 9:
            p9 = 'X';
            break;

        default:
            Console.Write("o número não é um, dois ou três");
            break;
    }

    char[,] matriz = new char[3, 3];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matriz[0, 0] = p1;
            matriz[0, 1] = p2;
            matriz[0, 2] = p3;
            matriz[1, 0] = p4;
            matriz[1, 1] = p5;
            matriz[1, 2] = p6;
            matriz[2, 0] = p7;
            matriz[2, 1] = p8;
            matriz[2, 2] = p9;
        }
    }


    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"    | {matriz[i, j]}");

        }
        Console.WriteLine();
        Console.Write("  --------------------");
        Console.WriteLine();
    }



    Console.Write("JOGADOR 2: ");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine();


    switch (n2)
    {
        case 1:
            p1 = 'O';
            break;

        case 2:
            p2 = 'O';
            break;

        case 3:
            p3 = 'O';
            break;


        case 4:
            p4 = 'O';
            break;

        case 5:
            p5 = 'O';
            break;

        case 6:
            p6 = 'O';
            break;

        case 7:
            p7 = 'O';
            break;

        case 8:
            p8 = 'O';
            break;

        case 9:
            p9 = 'O';
            break;

        default:
            Console.Write("o número não é um, dois ou três");
            break;
    }

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matriz[0, 0] = p1;
            matriz[0, 1] = p2;
            matriz[0, 2] = p3;
            matriz[1, 0] = p4;
            matriz[1, 1] = p5;
            matriz[1, 2] = p6;
            matriz[2, 0] = p7;
            matriz[2, 1] = p8;
            matriz[2, 2] = p9;
        }
    }

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"    | {matriz[i, j]}");

        }
        Console.WriteLine();
        Console.Write("  --------------------");
        Console.WriteLine();
    }



    
        if
        (matriz[0, 0] == 'X' && matriz[0, 1] == 'X' && matriz[0, 2] == 'X' ||
        (matriz[0, 0] == 'O' && matriz[0, 1] == 'O' && matriz[0, 2] == 'O') ||
        (matriz[1, 0] == 'X' && matriz[1, 1] == 'X' && matriz[1, 2] == 'X') ||
        (matriz[1, 0] == 'O' && matriz[1, 1] == 'O' && matriz[1, 2] == 'O') ||
        (matriz[2, 0] == 'X' && matriz[2, 1] == 'X' && matriz[2, 2] == 'X') ||
        (matriz[2, 0] == 'O' && matriz[2, 1] == 'O' && matriz[2, 2] == 'O') ||
        (matriz[0, 0] == 'X' && matriz[1, 0] == 'X' && matriz[2, 0] == 'X') ||
        (matriz[0, 0] == 'X' && matriz[1, 0] == 'X' && matriz[2, 0] == 'X') ||
        (matriz[0, 0] == 'O' && matriz[1, 0] == 'O' && matriz[2, 0] == 'O') ||
        (matriz[1, 0] == 'X' && matriz[1, 1] == 'X' && matriz[1, 2] == 'X') ||
        (matriz[1, 0] == 'O' && matriz[1, 1] == 'O' && matriz[1, 2] == 'O') ||
        (matriz[2, 0] == 'X' && matriz[2, 1] == 'X' && matriz[2, 2] == 'X') ||
        (matriz[2, 0] == 'O' && matriz[2, 1] == 'O' && matriz[2, 2] == 'O') ||
        (matriz[0, 0] == 'X' && matriz[1, 1] == 'X' && matriz[2, 2] == 'X') ||
        (matriz[0, 0] == 'O' && matriz[1, 1] == 'O' && matriz[2, 2] == 'O')) 
        //faltou quando todas as opções estão marcadas

        {
            Console.WriteLine("Fim de Jogo");
        fimDeJogo;
        }


    return true;


} while (fimDeJogo);
//p1 == ' ' || p2 == ' ' || p3 == ' ' || p4 == ' ' || p5 == ' ' || p6 == ' ' || p7 == ' ' || p8 == ' ' || p9 == ' '); 








