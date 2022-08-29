/*Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation( int n1, int n2)
{
    int result = 1;
  for(int i=1; i <= n2; i++)
  {
    result = result * n1;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите положительное число B: ");
  int num2= Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumber( int num)
{
 int result = 0;
  while (num!=0)
  {
   result = result + num %10;
    num/=10;
  }
 return result;
}

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(number);
Console.WriteLine($"Сумма равна {result}");



Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateRandomArray( int size, int minValue, int maxValue)
{
  int[]newArray = new int [size];
  for (int i = 0; i < size; i++)
  {
    newArray[i] = new Random(). Next ( minValue ,  maxValue+1);
  }
  return newArray;
}

void ShowArray( int[] array)
{
  for (int i = 0; i < array.Length; i++)
   Console.Write(array[i]+ " ");
Console.WriteLine();
}

int [] CreateArray ( int size)
{
  int[]newArray = new int [size];
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Input {i + 1} element of {size} : ");
    newArray[i] = Convert.ToInt32 (Console.ReadLine());
  }
  return newArray;
}
 int [] array = CreateArray ( 8);
 ShowArray(array);
*/