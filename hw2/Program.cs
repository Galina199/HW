/* Задача 1. апишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int num1 = num/10 %10;
    return num1;
}
Console.Write ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(number);

Console.WriteLine(result);


 Задача 2 . Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

 int TheThirdDigit(int num)
 {  
    if ( num > 99  )
{
    num %=10;
}
 else
 {
  Console.WriteLine("Третьей цифры нет");
 }
   return num;
 }

Console.Write ("Введите трёхзначное число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = TheThirdDigit(number2);

Console.WriteLine(result);*/

/*Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int DayOfTheWeek(int day)
{
 if ( day == 6|| day == 7 )
 {
  Console.WriteLine("да, это выходной день");
 }
 else
  {
   Console.WriteLine(" нет, этот день не выходной");
 }
 return day;
}
Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
int result =DayOfTheWeek(number);
Console.WriteLine(result);
*/
