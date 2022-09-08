// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int SumDigitals(int number)
    
{
    int sum = number % 10;
    if (number == 0) return sum;
    
    return sum += SumDigitals(number / 10);  

}

int result = SumDigitals(453);
System.Console.WriteLine($"{453} -> {result}");
