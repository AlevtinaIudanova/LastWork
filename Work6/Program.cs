// Написать программу показывающие первые N чисел, для которых каждое с
//ледующее равно сумме двух предыдущих. Первые два элемента 
//последовательности задаются пользователем




Console.Write("Enter FirstNumber: ");
int n1 = int.Parse(Console.ReadLine()!);


Console.Write("Enter SecondNumber: ");
int n2 = int.Parse(Console.ReadLine()!);


double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = n1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
