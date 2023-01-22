Console.Clear();
Console.WriteLine("3. Возведите число А в натуральную степень B используя цикл.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int exponent = int.Parse(Console.ReadLine());

int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

Console.WriteLine($"{number} ^ {exponent} = {result}");
Console.WriteLine();