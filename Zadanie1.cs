using System;

Console.Write("Введите размер массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[razmer];

for (int i = 0; i < razmer; i++)
{
    Console.Write("Введите элемент: ");
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Массив:");

for (int i = 0; i < razmer; i++)
{
    Console.Write(massiv[i] + " ");
}