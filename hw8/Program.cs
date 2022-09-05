//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*Console.WriteLine("Enter the number of rows in the array");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns in the array");
int column = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[line, column];
FillArrayRandomNumbers(num);
Console.WriteLine();
Console.WriteLine("Your array");

PrintArray(num);

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < num.GetLength(1) - 1; z++)
        {
            if (num[i, z] < num[i, z + 1]) 
            {
                int temp = 0;
                temp = num[i, z];
                num[i, z] = num[i, z + 1];
                num[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Array with ordered values");
PrintArray(num);

void FillArrayRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr [i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой  {GetRowNumber(array)}");

int[,] GetArray(int m, int n, int min, int max)
 {
   int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          result[i, j] = new Random().Next(min, max +1);
        }
      }
      return result;
    }

  void PrintArray(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
      }
    }
int GetRowNumber (int [,] array)
    {
      int row = 0;
      int minsum = 0;
      for (int i = 0; i < array.GetLength(1); i++)
      {
        minsum = minsum + array[0,i];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          row = i;
        }
      }
      return row;
    }
     

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
            

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10); 
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr [i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("Размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandom(matrixA);
FillArrayRandom(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);



//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int arrSizeX = 2;
int arrSizeY = 2;
int arrSizeZ = 2;
int minNum = 10;
int maxNum = 99;
int[,,] testArr = new int[arrSizeX, arrSizeY, arrSizeZ];

Console.Clear();
FillArrayRandomNumber(testArr, minNum, maxNum);
PrintArrayIdex(testArr);

void FillArrayRandomNumber(int[,,] arr, int minNum = 0, int maxNum = 9)
{
 Random rand = new Random();

 for (int i = 0; i < arr.GetLength(0); i++)
    {
 for (int j = 0; j < arr.GetLength(1); j++)
        {
 for (int h = 0; h < arr.GetLength(2); h++)
            {
 while (arr[i, j, h] == 0)
                {
 int number = rand.Next(minNum, maxNum + 1);

 if (IsNumberInArray(arr, number) == false)
                    {
 arr[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int h = 0; h < arr.GetLength(2); h++)
            {
                if (arr [i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArrayIdex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int h = 0; h < arr.GetLength(2); h++)
            {
                Console.Write(arr [i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}


//Задача 62: Заполните спирально массив 4 на 4.
int n = 7;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/