// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 & number > 99)
{
    int SecondDigit = number % 100 / 10;
    Console.WriteLine("Вторая цифра числа " + number + " это " + SecondDigit);
}
else
{
    Console.WriteLine(number + " не трёхзначное число");
}