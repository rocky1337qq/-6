using System;

    Console.Write("Введите размер массива: ");
    int razmer = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[razmer];

    Console.WriteLine("Введите элементы массива:");

    for (int i = 0; i < razmer; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    int[] noviyArray = new int[razmer];

    int nachalo = 0;

    for (int i = 0; i < razmer; i++)
    {
        if (i % 2 == 0)
        {
            noviyArray[i] = array[^(i + 1)];
        }
        else
        {
            noviyArray[i] = array[nachalo];
            nachalo++;
        }
    }

    Console.WriteLine("Массив в заданном порядке:");

    for (int i = 0; i < razmer; i++)
    {
        Console.Write(noviyArray[i] + " ");
    }

    Console.WriteLine();

    Console.WriteLine("Массив в правильном порядке:");

    for (int i = 0; i < razmer; i++)
    {
        Console.Write(array[i] + " ");
    }
}
}