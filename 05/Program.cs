Console.Clear();
Console.WriteLine("5. Написать программу вычисления произведения чисел от 1 до N.");
Console.Write("Введите число: ");
string writeN = Console.ReadLine();
int number = int.Parse(writeN);

Console.WriteLine($"Произведение чисел от 1 до {number} равно {GetNumbersComposition(number)}.");

int GetNumbersComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}