Console.Clear();
Console.WriteLine("6. Показать кубы чисел, заканчивающихся на четную цифру.");
Console.Write("Введите число до которого будут производится вычисления: ");
int numberN = int.Parse(Console.ReadLine());

int number = 1;
while (number <= numberN)
{
    int cube = number * number * number;
    if (cube % 2 == 0) Console.WriteLine($"Число {number} в кубе равно {cube}.");
    number++;
}