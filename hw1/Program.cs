/* Задача1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1, num2;
Console.Write("Введите первое число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
num2 = Convert.ToInt32(Console.ReadLine());
if ( num1 > num2)
 {
    Console.WriteLine ("Число " + num1 + " больше, чем " + num2);
 }
  else
  {
    Console.WriteLine ("Число " + num2 +" больше, чем " + num1);
  }


Задача2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3;

Console.Write("Введите первое число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max= num1;
if (num2 > max) max= num2;
if (num3 > max) max= num3;

Console.Write ("max=");
Console.WriteLine(max);


Задача 3.  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num;

Console.Write("Введите  число:");
num = Convert.ToInt32(Console.ReadLine());

if( num % 2 == 0)
{
 Console.Write("Введенное число является четным");
}
 else
 {
  Console.WriteLine("Введенное число четным не является");
 }




Задача4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
int num1;
int a = 1;
bool not = true;

Console.Write("Введите  число:");
num1 = Convert.ToInt32(Console.ReadLine());
   
Console.WriteLine("Чётные числа от 1 до " + num1);
while (a <= num1)
 {
   if (a % 2 == 0)
  {
   Console.Write(a + ", ");
     not = false;
  }
     a++;
  }

   if (not)
   {
     Console.WriteLine("Нет чётных чисел!");
   }

     */      