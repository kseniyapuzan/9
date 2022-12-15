/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
/*
Console.Write($"Введите число M, которому соответствует количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[n];

void InputNumbers(int n){
for (int i = 0; i < n; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(n);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
*/


/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
double calculateY(double x, double k, double b)
{
    return (k * x) + b;
}
*/