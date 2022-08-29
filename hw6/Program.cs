//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//

/*void ShowArray( int[] array)
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
    Console.Write($"Введите {i + 1} число {size} : ");
    newArray[i] = Convert.ToInt32 (Console.ReadLine());
  }
  return newArray;
}

int SumOfPositive (int [] array)
{
    int sum = 0 ;
    for( int i = 0; i < array.Length; i++)
     if (array[i] > 0) sum+=array[i];
     return sum;
}

 int [] array = CreateArray ( 13);
 ShowArray(array);
 Console.WriteLine (" Сумма положительных чисел равна " + SumOfPositive(array));

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение b1:");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1:");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
double k2=Convert.ToDouble(Console.ReadLine());
double xIntersection=0;
double yIntersection=0;
if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу");
else 
{
    xIntersection =(b2-b1)/(k1-k2);
    yIntersection =k1*xIntersection+b1;
    Console.WriteLine("точка пересечения "+" ("+ xIntersection+" ;"+yIntersection+ ")");
}
  
*/