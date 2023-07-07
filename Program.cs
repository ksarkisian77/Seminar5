/*
задача №2
// напишите программу ,которая на вход принимает два числа и выдает,
// какое число больше а какое меньше.
*/
/*
Console.WriteLine("input first namber");
int FirstNum =Convert.ToInt32(Console.ReadLine() );
Console.WriteLine("Input second number");
int SecondNum =Convert.ToInt32(Console.ReadLine() );



if(FirstNum > SecondNum)
{
    Console.WriteLine($"first number {FirstNum}  is greater than the {SecondNum}");
}
else
{
    if(FirstNum == SecondNum)
    {
        Console.WriteLine($"Second number {SecondNum}  is equal first number  {FirstNum}");
    }
    else
    {
        Console.WriteLine($"Second number {SecondNum}  is equal first number  {FirstNum}");
    }
}
напиши программу, которая принимает на вход три числа и выдает из них максимальное 
*/
/*
using System;  
public class Exercise8  
{  
    public static void Main()
{
    int num1, num2, num3;
    Console.WriteLine("\n\n");
    Console.WriteLine("Find the largest of three numbers:\n");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("\n\n");
    Console.WriteLine("Input the 1st number :");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the  2nd number :");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the 3rd  number :");
    num3 = Convert.ToInt32(Console.ReadLine());
 
  if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.Write("The 1st Number is the greatest among three. \n\n");
        }
        else
        {
            Console.Write("The 3rd Number is the greatest among three. \n\n");
        }
    }
    else if (num2 > num3)
        Console.Write("The 2nd Number is the greatest among three \n\n");
    else
        Console.Write("The 3rd Number is the greatest among three \n\n");
}
}
*/
/*
Console.WriteLine("input first namber");
int FirstNum =Convert.ToInt32(Console.ReadLine() );

  Console.WriteLine("Введите число:");
            FirstNum = Convert.ToInt32(Console.ReadLine());

            if (FirstNum  % 2 == 1)
            {
                Console.WriteLine("Число " + FirstNum + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + FirstNum  + "является: ЧЁТНЫМ");
            }
*/
  Console.WriteLine("input first namber");
int FirstNum =Convert.ToInt32(Console.ReadLine() );
    int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            FirstNum= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + FirstNum);
            while (i <= FirstNum)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }
            

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }










