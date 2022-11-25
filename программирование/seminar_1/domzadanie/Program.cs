/*// Напишите программу, которая на вход принимает два числа и выдает,
//какое число большее,

// a = 5 , b = 7 -> max = 7 
// a = 2 , b = 10 -> max = 10
// a = -9 , b = -3 -> max = -3

Console.WriteLine("Укажи наибольшее число из двух");
int numbera = Convert.ToInt32(Console.ReadLine());
int numberb = Convert.ToInt32(Console.ReadLine());

if (  numbera < numberb)
{
    Console.WriteLine($" число {numbera} меньше ");
}
else 
{
    Console.WriteLine($" число {numberb} больше");
}




*/
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
Console.WriteLine("Укажи максимальное из трех числе");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int maximal_number = number1;

if (number1 > maximal_number )
{
    maximal_number = number1;
    Console.WriteLine($"{maximal_number} наибольшее");

}
else
{
    Console.Write("Введи число: ");
    Console.WriteLine($"{maximal_number} ");
}

if (number2> maximal_number )
{
    maximal_number = number2;
    Console.WriteLine($"{maximal_number} наибольшее");

}
else
{
    Console.Write("Введи число: ");
    Console.WriteLine($"{maximal_number} ");
}

if (number3 > maximal_number )
{
    maximal_number = number3;
    Console.WriteLine($"{maximal_number} наибольшее");

}
else
{
    Console.Write("Введи число: ");
    Console.WriteLine($"{maximal_number} ");
}



/*
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
*/
/*
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0)
{
    Console.WriteLine($"число {number1} является  четным числом");
}
else
{
      Console.WriteLine($"число {number1} не является");
}

if (number2 % 2 == 0)
{
    Console.WriteLine($"число {number2} является  четным числом");
}
else
{
      Console.WriteLine($"число {number2} не является");
}
if (number3 % 2 == 0)
{
    Console.WriteLine($"число {number3} является четным числом");
}
else
{
      Console.WriteLine($"число {number3} не является");
}

*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.WriteLine("Дорогой пользователь, введи N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num + 2;

while (current = num)
{
    Console.Write(current +  " ");
    current++;
}

num = 4;
*/