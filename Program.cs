// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.Write("input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("input number B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int stepenAotB (int a)
// {
//     int x = a;
//     for (int i = 0; i < b - 1; i++)
//     {
//         x = x*a;
//     }
//     return x;
// }
// Console.Write ($"степень числа А от В -> {stepenAotB(a)}");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.Write("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");
// int Length(int a)
// {
// int index = 0;
// while (a > 0)
// {
// a /= 10;
// index++;
// }
// return index;
// }
// int Sum(int a, int len)
// {
// int sum = 0;
// for (int i = 1; i <= len; i++)
// {
// sum += a % 10;
// a /= 10;
// }
// return sum;
// }


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] NewArray = new int [size];
    for(int i =0; i < size; i++)
    {
        NewArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return NewArray;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
}
Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
