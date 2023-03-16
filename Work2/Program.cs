// Найти сумму элементов от M до N, N и M заданы

int Summ(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else return N + Summ(M, N - 1);
}
Console.WriteLine("Enter M: ");
int SummM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter N: ");
int SummN = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"{Summ(SummM, SummN)}");