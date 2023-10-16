// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6;
int ThirdDigit (int chislo)
{
    while (chislo > 1000)
    {
        chislo /=10;
    }
    return chislo %10;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine(number + " третьей цифры не имеет");
}
else
{
    Console.WriteLine("Третья цифра " + ThirdDigit (number));
}