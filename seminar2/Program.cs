// напишите программу,которая получает на вход двухнчное число
//и показывает наибольшую цифру числа
/*
int Digits (int number)
{
   int ed = number % 10; // % остаток от деления пример 
   int dec = number / 10;

   int result;
   if (ed > dec){   //сравнение десятки и единицы
    return ed; //завершает метод
   }
   else return dec;

}

Console.Write("Input your 2digits number");
int user_num = Convert.ToInt32(Console.ReadLine());
int res = Digits(user_num);

Console.Write($"The biggest digit is  {res}");
*/

/*Напишите программу,которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
78- > 8
12-> 2
85 -> 8
*/
/*

int randomNum = new Random().Next(10,100); // генератор двузначного числа9не включает 100)

int Digits ()
{
    int randomNum = new Random().Next(10, 100);
    Console.WriteLine("Your number is" + randomNum);
   int ed = randomNum % 10; // % остаток от деления пример 
   int dec = randomNum / 10;

   if (ed > dec){   //сравнение десятки и единицы
    return ed; //завершает метод
   }
   else return dec;
}
Console.Write("The biggest digit is"  + Digits());

*/
// Напишите программу , которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*void Cratnost(int num, int a, int b)
{
    if (num % a == 0 && num % b == 0) //проверка на кратноасть
    {
        Console.WriteLine($"Your number {num} is multiple of {a} and {b} ");
    }
    else Console.WriteLine($"Your number {num} is not multiple of {a} and {b}");
}

Console.Write("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your divider1: ");
int divider1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your divider2: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

Cratnost(user_num, divider1, divider2);
*/

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру
// 456- > 46, 789-> 79
/*
int Del()
{
    int randomNum = new Random().Next(100, 1000);
    Console.WriteLine("Your number is" + randomNum);
    int fut_dec = randomNum / 100; //деление нацело
    int fut_ed = randomNum % 10; //деление с остатком

    int new_num = fut_dec * 10 + fut_ed;
    return new_num;
}

Console.WriteLine($"Your new number is {Del()}");
*/

/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (без пеобразования типов)

456 -> 5
782 -> 8
918 -> 1
*/
/*void Cratnost(int abc)
{
    if ( abc > 99 && abc < 1000 )
    {
    
       int count = abc / 10 % 10;
    Console.WriteLine($"Your number {count} ");
    }
        
    else Console.WriteLine($"Your number {abc} not num ");
}

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Cratnost(num);

*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (без пеобразования типов)

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
Console.WriteLine("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

void Digits (int number)
{


   if (number < 100)
   {   
    Console.WriteLine("Третьей цифры нет"); 
   }
   return;

     if (number > 100 && number < 1000)
   {   
    Console.WriteLine($"Третья цифрa {number % 10} "); 

   }
   
    while (number > 1000)
    {
       number = number / 10;
    }
    Console.WriteLine($"Третья цифрa {number % 10} "); 
    }

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
 Digits(num);
*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
Console.Write("Enter the number the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( 
    number == 1 ? "NO " 
    :number == 2 ? "Thursday"
    :number == 3 ? "Wednesday"
    :number == 4 ? "Thursday"
    :number == 5 ? "Friday"
    :number == 6 ? "Saturday is a weekend! "
    :number == 7 ? "Sunday is a weekend!"
    :"Not a day of the week! ");
*/