//Задача 51 
 
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 
 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
 
// Сумма элементов главной диагонали: 1+9+2 = 12 
 
Console.Write("Ввудите m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
 
Console.Write("Введите n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
int[,] arrey = new int[m, n]; 
 
for (int i = 0; i < m; i++) 
{ 
    for (int j = 0; j < n; j++) 
    { 
        arrey[i, j] = new Random().Next(1, 100); 
    } 
} 
 
PrintArrey(arrey); 
Console.WriteLine(); 
 
int sumMassive = 0; 
 
for (int i = 0; i < m; i++) 
{ 
    for (int j = 0; j < n; j++) 
    { 
        if (i == j) 
        { 
            sumMassive = sumMassive + arrey[i, j]; 
            Console.Write($"{arrey[i, j]}"); 
        } 
        else Console.Write($"__"); 
    } 
    Console.WriteLine(); 
} 
 
Console.Write($"Сумма главной диагонали: {sumMassive}"); 
 
void PrintArrey (int[,] arrey) 
{ 
    for (int i = 0; i < m; i++) 
    { 
        for (int j = 0; j < n; j++) 
        { 
            Console.Write(arrey[i, j] + " "); 
        } 
        Console.WriteLine(); 
    } 
}
