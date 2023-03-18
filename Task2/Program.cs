//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int RecursionSumOfPositiveInteger(int M, int N)
{
    if (M==N) return N;
    else 
    return N + RecursionSumOfPositiveInteger(M, N-1);
}

int N = Prompt("Input the highest number: ");
int M = Prompt("Input the lowest number: ");
System.Console.WriteLine($"Sum of the numbers = {RecursionSumOfPositiveInteger(M, N)}");