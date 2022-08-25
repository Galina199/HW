
//Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void PalindromeNumber(string number)
{
 if (number[0]==number[4] || number[1]==number[3]){
 Console.WriteLine($"Данное число: {number} -  палиндром.");
  }
 else Console.WriteLine($"Данное число: {number} - не палиндром.");
}

Console.Write("Введите положительное пятизначное число: ");
string? number = Console.ReadLine();

if (number!.Length == 5){
 PalindromeNumber (number);
}
else Console.WriteLine($"Введите корректное число: ");

//Задача 2.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double CoordinatesOfPoints ( double xa, double ya, double za, double xb, double yb, double zb)
{
   double length = Math.Sqrt((xb-xa)*(xb-xa)+ (yb-ya)*(yb-ya)+(zb-za)*(zb-za));
   return length;
}

Console.Write(" Введите координату точки А по оси х: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координату точки А по оси y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координату точки A по оси z: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введитекоординату точки B по оси x: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координату точки B по оси y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координату точки B по оси z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double length = CoordinatesOfPoints(xa,ya,za,xb,yb,zb);
Console.Write($"Растояние между точками А и В равно {length}");


//Задача3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumbers( int num)
{
    for (int i = 1; i<= num; i++)
    {
        Console.Write( i*i*i + "  ");
    }
}
Console.Write("Введите целое положительное число: ");
int i = Convert.ToInt32(Console.ReadLine());
CubeNumbers(i);
