// Задача 60 
 
// Составить частотный словарь элементов двумерного массива.  
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
 
int m = InputNumbers("Введите m: "); 
int n = InputNumbers("Введите n: "); 
 
Console.WriteLine(); 
 
Console.WriteLine($"m = {m}, n = {n}."); 
 
Console.WriteLine(); 
 
int [,] arrey = new int[m, n]; 
CreateArrey(arrey); 
PrintArrey(arrey); 
 
Console.WriteLine(); 
 
int[] counter = new int[10]; 
int tempNumber = 0; 
 
for (int i = 0; i < counter.GetLength(0); i++) 
{ 
    tempNumber = 0; 
    for (int j = 0; j < arrey.GetLength(0); j++) 
    { 
        for (int k = 0; k < arrey.GetLength(1); k++) 
        { 
            if (i == arrey[j, k]) 
            { 
                tempNumber += 1; 
            } 
        } 
    } 
    counter[i] = tempNumber; 
} 
 
PrintCounter(counter); 
 
void PrintCounter(int[] counter) 
{ 
    for (int l = 0; l < counter.GetLength(0); l++) 
    { 
        if (counter[l] != 0) 
        { 
            Console.WriteLine($"{l} встречается {counter[l]} раз , "); 
        } 
    } 
} 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
} 
 
void CreateArrey(int[,] arrey) 
{ 
    for (int i = 0; i < m; i++) 
    { 
        for (int j = 0; j < n; j++) 
        { 
            arrey[i, j] = new Random().Next(10); 
        } 
    } 
} 
 
void PrintArrey(int[,] arrey) 
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