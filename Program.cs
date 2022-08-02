// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int DegreeOfNumber(int firstNum, int secondNum)
{
    int num = firstNum;
    for(int i = 2; i <= secondNum; i++)
    {
        num = num * firstNum;
    }
    return num;
}

Console.Write("Введите целое первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое первое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = DegreeOfNumber(numberOne, numberTwo);

Console.Write($"Число {numberOne} в степени {numberTwo} = {result}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
void SumOfDigit(int num)
{
    int r, sum = 0, i;

    for(i = num; num!= 0; num = num / 10)
    {
         r = num % 10;
         sum = sum + r;
    }
    Console.WriteLine($"Сумма чисел числа {i} = {sum}.");
}

Console.Write("Введите число: ");
int numForSum = Convert.ToInt32(Console.ReadLine()); 

SumOfDigit(numForSum);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
//решение модернизированное из решения на семинаре.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }   
}
int arraySize = 8;

Console.Write("Введите начальный диапазон чисел: ");
int startValue = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите заключительный диапазон чисел: ");
int endValue = Convert.ToInt32(Console.ReadLine()); 

int[] digitalArray = CreateRandomArray(arraySize, startValue , endValue);
ShowArray(digitalArray);
*/
//решение через запрос от пользователей всех элементов массива.

int sizeOfArray = 8;
int[] myNewArray = new int[sizeOfArray];

for(int i = 0; i < sizeOfArray; i++)
{
    Console.Write("Введите элемент массива: ");
    myNewArray[i]= Convert.ToInt32(Console.ReadLine()); 
}

void ShowArray(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }   
}

ShowArray(myNewArray);
