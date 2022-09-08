// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое положительное число m:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число n:");
int N = Convert.ToInt32(Console.ReadLine());

///Метод вычисления функции Аккермана:
int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return Akkerman(numM - 1, 1);
    if (numM > 0 && numN > 0) return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    return Akkerman(numM, numN);
}

Console.WriteLine($"m = {M}, n = {N} -> A({M},{N}) = {Akkerman(M, N)}");
