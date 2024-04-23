//leia 10 numeros (vetor) inteiros e faça:
int[] numeros = new int[10];
int[] impares = new int[10];
int[] pares = new int[10];

Console.Write("Informe 10 numeros:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"\n{i + 1} - ");
    numeros[i] = int.Parse(Console.ReadLine());
}

//a) imprima o vetor lido;
Console.WriteLine("VETOR INSERIDO:");
for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i] + "  ");
}
Console.WriteLine("\n------------------------------------------------\n");

//b) imprima o vetor de trás pra frente;
Console.WriteLine("\nVETOR INSERIDO DE TRÁS PARA FRENTE:");
for (int i = 9; i >= 0; i--)
{
    Console.Write(numeros[i] + "  ");
}
Console.WriteLine("\n------------------------------------------------\n");

//c) imprima até a metade do vetor
Console.WriteLine("\nVETOR IMPRIMIDO ATÉ A METADE:");
for (int i = 0; i < 5; i++)
{
    Console.Write(numeros[i] + "  ");
}
Console.WriteLine("\n------------------------------------------------\n");

//d) guarde os valores impares em um novo vetor (sem os valores 0), e imprima os novos vetores;
for (int i = 0; i < 10; i++)
{
    // alimentando vetor de numeros PARES
    if (numeros[i] % 2 == 0)
    {
        for (int j = 0; j < 10; j++)
        {
            if (pares[j] == 0)
            {
                pares[j] = numeros[i];
                break;
            }
        }
    }
    // alimentando vetor de numeros IMPARES
    else
    {
        for (int j = 0; j < 10; j++)
        {
            if (impares[j] == 0)
            {
                impares[j] = numeros[i];
                break;
            }
        }
    }
}

// imprimindo vetor de PARES
Console.WriteLine("PARES:");
for (int i = 0; i < 10; i++)
{
    if (pares[i] != 0)
    {
        Console.Write(pares[i] + "  ");
    }
    else
    {
        break;
    }
}
Console.WriteLine("\n------------------------------------------------\n");

// imprimindo vetor de IMPARES
Console.WriteLine("IMPARES:");
for (int i = 0; i < 10; i++)
{
    if (impares[i] != 0)
    {
        Console.Write(impares[i] + "  ");
    } 
    else
    {
        break;
    }
}

Console.ReadLine();