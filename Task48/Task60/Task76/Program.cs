// Задача 76.

// Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰. Можно использовать рекурсию.

int n = InputNumbers("Введите число N: ");

int[] tempArrey = CreateArrey(n);
CreateRows(tempArrey);

void CreateRows(int[] arreyCheck)
{
  int[] arreyTemp = new int[arreyCheck.Length];
  int m = 1;
  int count = 0;
  int tempNumber = 0;
  int tempNumber2 = 0;
  int tempSwitch = 0;
  
  for (int i = 0; i < arreyCheck.Length; i++)
  {
    Array.Clear(arreyTemp);
    count = 0;
    if (arreyCheck[i] != 0)
    {
      arreyTemp[count] = arreyCheck[i];
      tempNumber2 = arreyCheck[i];

      for (int j = i; j < arreyCheck.Length; j++)
      {
        if (arreyCheck[j] % tempNumber2 != 0 || arreyCheck[j] / tempNumber2 == 1)
        {
          tempSwitch = 0;
          tempNumber = arreyCheck[j];
          for (int k = 0; k < count; k++)
          {
            if (tempNumber % arreyTemp[k] == 0) tempSwitch++;
          }
          if (tempSwitch == 0)
          {
            arreyTemp[count] = arreyCheck[j];
            count++;
            arreyCheck[j] = 0;
          }
        }
      }
      Console.WriteLine($"Группа {m++}: {PrintIntArrey(arreyTemp)}");
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int[] CreateArrey(int n)
{
  int[] temp = new int[n];
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = i + 1;
  }
  return temp;
}

string PrintIntArrey(int[] arrey)
{
  string result = string.Empty;
  for (int i = 0; i < arrey.Length; i++)
  {
    if (arrey[i] != 0) result += $"{arrey[i],1} ";
  }
  return result;
}
