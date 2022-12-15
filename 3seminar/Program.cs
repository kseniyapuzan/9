 /*                   y
                 |
                 |
  2              |         1 (x>0, y>0)
                 |
                 | 
__________________________________   x
                 |
                 |
  3              |          4
                 |
                 |

       2 (x<0,y>0) 
       3(x<0,y<0)
       4(x>0,y<0)
       */

       //


//  Напишите программу,которая принимает на вход (X и Y), причем X не рвно 0 и Y не равно 0 и выдает номер четверти плоскости, в которой находится точка.

void Frunkt (int x, int y)
{
     if (x > 0 && y > 0)
     Console.WriteLine("this point on 1 quater");
    else if (x < 0 &&  y > 0)
    Console.WriteLine("this point on 2 quater");
    else if (x < 0 && y < 0)
    Console.WriteLine("this point on 3 quater");
    else if (x > 0 && y < 0)
    Console.WriteLine("this point on 4 quater");
    
}


/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Write("Enter the number: ");
string num = ReadLine();
int number;
bool isNum = int.TryParse(num, out number);

/*if (num.Length > 5)
{
    WriteLine("It's not a 5-symbol number.");
}
else {
    if (isNum) {
        if ((num[0] == num[4]) && (num[1] == num[3])) {
             WriteLine("The number is polindrom");
        }
        else {
            WriteLine("The number is NOT polindrom");
        }
    }
    else
    {
        WriteLine("Enter the number!");
    }
}
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B(2, 1, -7), -> 15.84
//A(7, -5, 0); B(1, -1, 9)-> 11.53
//
Console.WriteLine("Введите xa: ");
double xa = double.Parse(Console.ReadLine());

Console.WriteLine("Введите ya: ");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Введите za: ");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Введите xb: ");
double xb = double.Parse(Console.ReadLine());

Console.WriteLine("Введите yb: ");
double yb = double.Parse(Console.ReadLine());

Console.WriteLine("Введите zb: ");
double zb = double.Parse(Console.ReadLine());

double ab = Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2);
ab = Math.Sqrt(ab); // корень
ab = Math.Round(ab, 2);//округление
Console.WriteLine($"Длина отрезка {ab}");

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)
{
   Console.Write($"{Math.Pow(i, 3)}, ");
}
   Console.Write($"{Math.Pow(number, 3)}");
