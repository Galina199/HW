//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


/*int[] GenerateRandomArray(int size, int start, int end)
{
int[] RandomArray = new int[size];
 for (int i = 0; i < size; i++)
 {
  RandomArray[i] = new Random().Next(start, end + 1);
 }
}

void ShowArray(int[] Array1)
{
for (int i = 0; i < Array1.Length; i++)
{
Console.WriteLine(Convert.ToString(Array1[i]));
}
}

int CountOfEven(int[] myArray2)
{
 int Count = 0;
for (int i = 0; i < myArray2.Length; i++)
 if (myArray2[i] % 2 == 0)
{
 Count = Count + 1;
}
return Count;
}

int[] myArray = new int[5];
myArray = GenerateRandomArray(5, 100, 999);
ShowArray(myArray);
Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));


 
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[size];
GenerateRandomArray(array1);
ShowArray(array1);
int sum = 0;

for (int i = 0; i< array1.Length; i+=2)
    sum = sum + array1[i];

Console.WriteLine($" сумма нечетных элементов  = {sum}");

void GenerateRandomArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
 {
  array[i] = new Random().Next(1,10);
}
}


void ShowArray(int[] array2)
{
    for(int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i] + " ");
        }
    Console.WriteLine();
}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers = new double [10];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
DifferenceМinМax(numbers);

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100);
    }
}

void DifferenceМinМax(double[] number)
{
    double min = number[0];
    double max = number[0];
    for (int i = 0; i < n; i++)
    {
        if (number[i] > max)
        {
            max = number[i];
        }
        if (number[i] < min)
        {
            min = number[i];
        }
    }
    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементоми массива равна: {diff}");
}

void OutputArrayString(double[] arrayString)
{
    string stringArray = "[";
    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.WriteLine ($"Массив: {stringArray}");
}
*/