// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N:");
int N = Convert.ToInt32(Console.ReadLine());

void SumNaturalNumber(int numM, int numN, int sum)
{
    if (numM > numN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N -> {sum}");
        return;
    }
    sum = sum + (numM++);
    SumNaturalNumber(numM, numN, sum);
}

SumNaturalNumber(M, N, 0);