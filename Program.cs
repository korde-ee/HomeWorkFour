// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

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