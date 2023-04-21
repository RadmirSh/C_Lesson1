// 2. Написать программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел

Console.WriteLine("Please write number 1");

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write number 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please write number 3");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b) max = b;
if (max < c) max = c;

System.Console.WriteLine("max of this numbers = " + max);