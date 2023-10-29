// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] CreateArray (int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        System.Console.WriteLine("Введите число: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositive(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}   ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Введите количество чисел: ");
int M=Convert.ToInt32(Console.ReadLine());
int[] array=CreateArray(M);
PrintArray(array);
System.Console.WriteLine(CountPositive(array));