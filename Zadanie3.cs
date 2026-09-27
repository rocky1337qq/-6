using System;

int[,] massiv = new int[10, 10];

Random random = new Random();

Console.WriteLine("Двумерный массив:");

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        massiv[i, j] = random.Next(1, 4);
        Console.Write(massiv[i, j] + " ");
    }

    Console.WriteLine();
}

int bolshayaSumma = 0;
int bolshoeProizvedenie = 0;

for (int i = 0; i < 10; i++)
{
    int summa = 0;

    for (int j = 0; j < 10; j++)
    {
        summa += massiv[i, j];
    }

    Console.WriteLine("Сумма строки " + i + ": " + summa);

    if (summa > bolshayaSumma)
    {
        bolshayaSumma = summa;
    }
}

for (int j = 0; j < 10; j++)
{
    int proizvedenie = 1;

    for (int i = 0; i < 10; i++)
    {
        proizvedenie *= massiv[i, j];
    }

    Console.WriteLine("Произведение столбца " + j + ": " + proizvedenie);

    if (proizvedenie > bolshoeProizvedenie)
    {
        bolshoeProizvedenie = proizvedenie;
    }
}

Console.WriteLine("Самая большая сумма строки: " + bolshayaSumma);
Console.WriteLine("Самое большое произведение столбца: " + bolshoeProizvedenie);
    }