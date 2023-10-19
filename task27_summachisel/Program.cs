// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit (int a)
{
    int sum=0;
    for (int i = a; i > 0; i/=10)
    {
        sum=sum%10+i;
    }
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigit(number));