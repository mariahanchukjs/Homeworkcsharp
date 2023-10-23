// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int [] generateArray (int length, int minValue, int maxValue) {
    int [] numbers = new int [length];
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue + 1);
    }
    return numbers;
}
void printArray(int[] array) {
    System.Console.Write(array[0]);             
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");  
    }
    System.Console.WriteLine();                 
}
int [] array = generateArray(8, 0, 100);
printArray(array);