/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/

/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
// заполнение двумерной таблицы рандомными целыми числами
int[,] ToFillTable(int n, int m)
{
    int[,] table = new int[n, m];
    var rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        { table[i, j] = rand.Next(0, 10); }
    }
    return table;
}

// вывод на печать таблицы
void ToPrintTable(int[,] table)
{
    int rows = table.GetUpperBound(0) + 1;    // количество строк
    int columns = table.Length / rows;        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{i + 1}-я:  ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{table[i, j]}  ");
        }
        Console.WriteLine();
    }
}
//подсчет суммы строк и запись их в одномерный массив
int[] ToCountSums(int[,] table)
{
    int rows = table.GetLength(0);
    int columns = table.GetLength(1);
    int[] sums = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sums[i] = sums[i] + table[i, j];
        }
    }
    return sums;
}
// поиск минимального элемента в массиве
int TofindMinInArray(int[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[min] > array[i]) min = i;
    }
    return min;
}
string input_text = "количество строк таблицы";
int n = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов таблицы";
int m = int.Parse(ToInputVar(input_text));
int[,] table = ToFillTable(n, m);
ToPrintTable(table);
int[] sums = ToCountSums(table);
int minnum=TofindMinInArray(sums);
Console.WriteLine("Строка с наименьшей суммой элементов: " + (minnum+1)+"-я;");
Console.WriteLine("Сумма элементов строки: "+(sums[minnum])+";");
*/
/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
// заполнение двумерной таблицы рандомными целыми числами
int[,] ToFillTable(int n, int m)
{
    int[,] table = new int[n, m];
    var rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        { table[i, j] = rand.Next(0, 10); }
    }
    return table;
}

// вывод на печать таблицы
void ToPrintTable(int[,] table)
{
    int rows = table.GetLength(0);    // количество строк
    int columns = table.GetLength(1);        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        //Console.Write($"{i + 1}-я:  ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{table[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int[] ToFindIRowFromMatrixA(int[,] matrix, int i) //найти i-ую строку в матрице А
{
    int columns = matrix.GetLength(1);
    int[] array = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        array[j] = matrix[i, j];//записать в одномерный массив i-ую строку матрицы
    }
    return array;
}
int[] ToFindJColumnFromMatrixB(int[,] matrix, int j) //найти j-ый столбец в матрице B
{
    int rows = matrix.GetLength(0);
    int[] array = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        array[i] = matrix[i, j];//записать в одномерный массив j-ый столбец матрицы
    }
    return array;
}
//найти произведение векторов 
int ToMultiplyVectors(int[] array1, int[] array2)
{
    int product;
    int sum=0;
    for (int i = 0; i < array1.Length; i++)
    {
        product = array1[i] * array2[i];
        sum = sum + product;
    }
    return sum;
}
//найти произведение матриц
int[,] ToMultiplyMatrix(int[,] matrixA,int[,] matrixB)
{
int rows1 = matrixA.GetLength(0);
int rows2 = matrixB.GetLength(0);
int columns1 = matrixA.GetLength(1);
int columns2 = matrixB.GetLength(1);
if (columns1 == rows2)
{
    int[,] matrixC = new int[rows1, columns2]; // размерность результирующей матрицы
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            matrixC[i, j] = ToMultiplyVectors(ToFindIRowFromMatrixA(matrixA,i),ToFindJColumnFromMatrixB(matrixB,j));
        }
    }
        return matrixC;
}
else
{
    Console.WriteLine("Матрицы несовместимы, количество столбцов матрицы А должно быть равным количеству строк матрицы В!");
    return null;
}
}
string input_text = "количество строк матрицы A";
int n1 = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов матрицы A";
int m1 = int.Parse(ToInputVar(input_text));
int[,] matrixA = ToFillTable(n1, m1);
ToPrintTable(matrixA);

input_text = "количество строк матрицы B";
int n2 = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов матрицы B";
int m2 = int.Parse(ToInputVar(input_text));
int[,] matrixB = ToFillTable(n2, m2);
ToPrintTable(matrixB);
int[,] matrixC=ToMultiplyMatrix(matrixA,matrixB);
Console.WriteLine("Произведение матриц А и В");
ToPrintTable(matrixC);
*/
/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
// заполнение трехмерного массива рандомными целыми двузначными числами
int[,,] ToFill3DArray(int l, int m, int n)
{
    int[,,] array = new int[l, m, n];
    var rand = new Random();
    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                array[i, j, k] = rand.Next(-99, 100);
                if (array[i, j, k] < 10 & array[i, j, k] > -10)
                {k--;}
            }
        }
    }
    return array;
}
// вывод на печать 3D массива
void ToPrint3DArray(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);
    Console.WriteLine();
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.Write($"{array[i, j, k]}({i + 1},{j + 1},{k + 1})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
string input_text = "количество элементов 1 измерения массива";
int l = int.Parse(ToInputVar(input_text));
input_text = "количество элементов 2 измерения массива";
int m = int.Parse(ToInputVar(input_text));
input_text = "количество элементов 3 измерения массива";
int n = int.Parse(ToInputVar(input_text));
int[,,] array = ToFill3DArray(l, m, n);
ToPrint3DArray(array);
*/
/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    return Console.ReadLine(); ;
}
// вывод на печать таблицы
void ToPrintTable(int[,] table)
{
    int rows = table.GetUpperBound(0) + 1;    // количество строк
    int columns = table.Length / rows;        // количество столбцов
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{i + 1}-я:  ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{table[i, j]}  ");
        }
        Console.WriteLine();
    }
}
string input_text = "количество строк таблицы";
int downbound = int.Parse(ToInputVar(input_text));
input_text = "количество столбцов таблицы";
int rightbound = int.Parse(ToInputVar(input_text));
int[,] table = new int[downbound, rightbound];

int i = 0;
int j = 0;
string direction = "right";
int leftbound = -1;
int upperbound = 0;

for (int count = 1; count < table.Length + 1; count++) // заполнить двумерный массив числами от 1 до (length + 1) 
{
    table[i, j] = count;
    //выбор направления
    if (direction == "right") j++;  
    else if (direction == "left") j--;   
    else if (direction == "down") i++;   
    else i--;                       
    //проверка углов
    if (direction == "right" && j == rightbound) //если дошли слева направо, то строка+1 и идем вниз
    {
        j--;
        i++;
        direction = "down";
        rightbound--;
    }
    else if (direction == "left" && leftbound == j) //если дошли справа налево, то строка-1 и идем вверх
    {
        j++;
        i--;
        direction = "up";
        leftbound++;
    }
    else if (direction == "down" && i == downbound) //если дошли сверху вниз, то столбец -1 и идем влево
    {
        i--;
        j--;
        direction = "left";
        downbound--;
    }
    else if (direction == "up" && upperbound == i)//если дошли снизу вверх, то столбец+1 и идем вправо
    {
        i++;
        j++;
        direction = "right";
        upperbound++;
    }
}
ToPrintTable(table);