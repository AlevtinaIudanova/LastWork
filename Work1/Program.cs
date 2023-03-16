// Показать натуральные числа от M до N, N и M заданы

/*int M;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out M);

int N;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int index = 1;
while (index <= N)
{


    Console.Write($"{index} ");

    index++;
}*/

string NumbersRec(int M, int N)
{
    if (M <= N) return M + NumbersRec(M + 1, N);
    else return string.Empty;
}

Console.WriteLine("Enter M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumbersRec(M, N));