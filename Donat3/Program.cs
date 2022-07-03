// Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.
//3-> 1, 8, 27
//5-> 1, 8, 27, 64, 125


System.Console.Write($" Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        SqrtArray[i] = number * number;
        number++;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 2 = "); // Таблица кубов
        System.Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);