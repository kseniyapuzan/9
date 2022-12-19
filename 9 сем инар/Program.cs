/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
int n = 0;

Console.Write("Введите натуральное число: ");
bool boolN = int.TryParse(Console.ReadLine(), out int numberN);

//Проверяем на число
if (!boolN)
{
    Console.WriteLine("Введено неверное значение!");
    return;
}
else
{
    n = numberN;
}


//Рекурсия 
void printAllNaturalNumbers(int m)
{
    if (m == 1)
    {
        Console.Write(1);
        return;
    }
    else
    {
        Console.Write(m + ", ");
        printAllNaturalNumbers(m - 1);
    }
}

printAllNaturalNumbers(n);
*/

/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNums (int M, int N)
{
    if (N < M) return 0;
    return SumNums(M, N - 1) + N;
}

Console.WriteLine (SumNums(1, 15)); 
Console.WriteLine (SumNums(4, 8));
*/

/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int akkerman(int m, int n) {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0 && m > 0) {
            return akkerman(m - 1, 1);
        }
        else {
            return akkerman(m - 1, akkerman(m, n - 1));
        }
    }

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана от {m}, {n} равна {akkerman(m,n)}");
*/
/*Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
*/
/*
string BinarSystem (int num)
    {
        if (num == 0) 
            return "";
        return BinarSystem(num/2) + (num%2).ToString();
        
    }

Console.WriteLine ("Введите  число: ");
int number = Convert. ToInt32(Console.ReadLine());
string res = BinarSystem (number);
Console.WriteLine ($"Ваше  число {number} в бинарной системе  ->   {res}: ");
