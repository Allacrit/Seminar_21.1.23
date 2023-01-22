Console.Clear();
Console.WriteLine("02. Найти сумму чисел от 1 до А.");

Console.Write("Введите число:   ");
string stringNumberA = Console.ReadLine();
int numberA = Convert.ToInt32(stringNumberA);

int GetNumbersSum(int numA)
{
    int number = 1;
    int sum = 0;
    for (int i = 0; i < numA; i++)
    {
        sum = sum + number;
        number++;
    }
    return sum;
}

int NumbersSum = GetNumbersSum(numberA);
Console.WriteLine($"Сумма чисел от 1 до {numberA} составляет {NumbersSum}.");