Console.Clear();
Console.WriteLine("4. Подсчитать сумму цифр в числе.");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int numberClone = number;
int sumDigit = 0;

while (numberClone > 0)
{
    int digit = numberClone % 10;
    sumDigit = sumDigit + digit;
    numberClone = numberClone / 10;
}

Console.WriteLine($"Сумма цифр числа {number} равна {sumDigit}.");