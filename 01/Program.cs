Console.Clear();
Console.WriteLine("1. Найти кубы чисел от 1 до N.");
Console.Write("Введите число:   ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int[] GetCubeTable(int newNum)
{
    int[] cubs = new int[newNum];
    int number = 1;
    for (int i = 0; i < newNum; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}

int[] CubeTable = GetCubeTable(num);
PrintCubs(CubeTable);