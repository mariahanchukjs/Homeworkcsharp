// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void DayofTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine(dayNumber + " -> да, это выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine(dayNumber + " -> это не день недели, введите от 1 до 7");
    }
    else
    {
        Console.WriteLine(dayNumber + " -> нет, это будний");
    }
}
Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
DayofTheWeek (number);

