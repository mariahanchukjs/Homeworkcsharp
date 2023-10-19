//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Exponentation (int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *=a;
    }
    Console.WriteLine(result);
}
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Exponentation(A, B);