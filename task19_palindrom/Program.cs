// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное / False
int IsPalindrome (int number) {
    int revNumber = 0;
    for (int i = number; i > 0; i/=10)
    {
        revNumber = revNumber * 10 + i % 10;
    }
    if (number == revNumber)
    {
        Console.WriteLine(number + " -> True");
    }  
    else
    {
        Console.WriteLine(number + " -> False");
    }
    return number;
}  
Console.Write("Введите число: ");        
int num = Convert.ToInt32(Console.ReadLine());   
if (num > 10000 & num < 99999)
{
    IsPalindrome(num);
}
else
{
    Console.WriteLine(num + " не пятизначное число");
    Console.WriteLine("False");
}