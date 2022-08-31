//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*void PrintArray( int[,]arr)
{
    for( int i=0;i < arr.GetLength(0); i++ )
{
        for (int j = 0; j< arr.GetLength(1); j++)
         {
            Console.Write($"{arr [i, j]} ");
        }
           Console.WriteLine();
}
}

void FillArray( int [,] arr)
{
for( int i=0;i < arr.GetLength(0); i++ )
    {
        for (int j = 0; j< arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}
Console.Write (" Введите количество строк  в массиве " );
int m = Convert.ToInt32(Console.ReadLine());
Console.Write (" Введите количество столбцов  в массиве " );
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m, n];
PrintArray(array);
FillArray(array);
PrintArray(array);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine (" Введите номер строки  " );
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Введите номер столбца  " );
int n = Convert.ToInt32(Console.ReadLine());
int [,] arr  = new int [5, 5];

FillArray(arr );

if (n > arr .GetLength(0) || m > arr .GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {arr [n-1,m-1]}");
}

PrintArray(arr );

void PrintArray( int[,]arr )
{
    for( int i=0;i < arr .GetLength(0); i++ )
{
        for (int j = 0; j< arr .GetLength(1); j++)
         {
            Console.Write($"{arr [i, j]} ");
        }
           Console.WriteLine();
}
}

void FillArray( int [,] arr )
{
for( int i=0;i < arr .GetLength(0); i++ )
    {
        for (int j = 0; j< arr .GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1, 10);
        }
    }
}
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк в массиве ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
FillArray(arr);
PrintArray(arr);

for (int j = 0; j < arr.GetLength(1); j++)
{
    double average  = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + arr[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();

void PrintArray( int[,]arr )
{
    for( int i=0;i < arr .GetLength(0); i++ )
{
        for (int j = 0; j< arr .GetLength(1); j++)
         {
            Console.Write($"{arr [i, j]} ");
        }
           Console.WriteLine();
}
}

void FillArray( int [,] arr )
{
for( int i=0;i < arr .GetLength(0); i++ )
    {
        for (int j = 0; j< arr .GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1, 10);
        }
    }
}
*/