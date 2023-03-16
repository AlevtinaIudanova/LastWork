// Найти сумму цифр числа


int SumNumber(int number)
{
    if (number == 0)
        return 0;
    return SumNumber(number / 10) + number % 10;
}
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumber(number));