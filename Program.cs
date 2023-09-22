int[] numbers = new int[] { 1, 3, 5, 7, 11, 13, 17 };

Console.WriteLine("Квадраты чисел");
Console.WriteLine();
Console.WriteLine("Дан ряд чисел:");

for(int i = 0; i < 7; i++)
{

    Console.Write(numbers[i] + ",");

}

Console.WriteLine();
Console.Write("Квадраты этих чисел:");

for(int i = 0; i < 7; i++)
{

    Console.Write(numbers + "=" + (numbers[i] * numbers[i]) + ",");

}