// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//https://github.com/profimars/C-Seminar5Task41
int[] CreateArray(int M)
{
    int[] AA = new int[M];
    Random rnd = new Random();
    for (int i = 0; i < M; i++)
    {
        AA[i] = rnd.Next(-10, 10);
    }
    return AA;
}

void ShowArray(int[] QQ)
{
    foreach (int element in QQ)
    {
        Console.Write(element + "; ");
    }
}

int CountPozitivElements(int[] QQ)
{
    int k = 0;
    for (int i = 0; i < QQ.Length; i++)
    {
        if (QQ[i] > 0)
            k++;
    }
    return k;
}

Console.WriteLine("Введите число М ");
int M = Convert.ToInt32(Console.ReadLine());
int[] QQ = CreateArray(M);
ShowArray(QQ);
Console.WriteLine();
int rez = CountPozitivElements(QQ);
Console.WriteLine("Количество чисел больше 0 равно " + rez);