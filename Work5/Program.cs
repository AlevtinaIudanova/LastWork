// Написать программу возведения числа А в целую стень B

Console.Write("Enter A number: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter B step: ");
int stepB = int.Parse(Console.ReadLine());

int result(int A, int B)
{
    if (B == 0) return 1;
    else return result(A, B - 1) * A;
}


Console.WriteLine($"{result(numberA, stepB)}");