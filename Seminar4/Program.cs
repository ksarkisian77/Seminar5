/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

using System;

class program
{
static void Main (string[] args)
{
    Console.WriteLine(" введите число А ");
     int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" введите число B");
     int B = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    Console.WriteLine("резутьтат: "+ result);
}
}
*/
/*using System;
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int remainder;

        while (number > 0)
        {
            remainder = number % 10;
            sum += remainder;
            number /= 10;
        }

        Console.WriteLine("Сумма цифр: " + sum);
    }
}
*/
 //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
using System;

class Program 
{
    static void Main(string[] args)
    {
        int[] numbers ={1 ,2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Элементы массива:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
 