// Задача 59.

// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений:");

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] arrey = new int[m, n];
FillArrey(arrey);
PrintArrey(arrey);

int[,] positioneSmallElement = new int[1, 2];
positioneSmallElement = FindPositionSmallElement(arrey, positioneSmallElement);
Console.WriteLine($"Позиция элемента: ");
PrintArrey(positioneSmallElement);

int[,] arreyWithoutLines = new int[arrey.GetLength(0) - 1, arrey.GetLength(1) - 1];
DeleteLines(arrey, positioneSmallElement, arreyWithoutLines);
Console.Write($"Получившийся массив: ");
Console.WriteLine();
PrintArrey(arreyWithoutLines);

void FillArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(range);
        }
    }
}

void PrintArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(arrey[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FindPositionSmallElement(int[,] arrey, int[,] position)
{
    int temp = arrey[0, 0];
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (arrey[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = arrey[i, j];
            }
        }
    }
    Console.WriteLine($"Минимальный элемент: {temp}");
    return position;
}

void DeleteLines(int[,] arrey, int[,] positionSmallElement, int[,] arreyWithoutLines)
{
    int k = 0; int l = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (positioneSmallElement[0, 0] != i && positioneSmallElement[0, 1] != j)
            {
                arreyWithoutLines[k, l] = arrey[i, j];
                l++;
            }
        }
        l = 0;
        if (positioneSmallElement[0, 0] != i)
        {
            k++;
        }
    }
}

