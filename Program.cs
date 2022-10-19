//taking input from user﻿
Console.WriteLine("Enter a number: ");
//converting string to integer
int num = int.Parse(Console.ReadLine());
//count variable to count prime number
int count = 0;
for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        //counting the number
        count++;
    }
}
//checking prime number
if (count == 2)
{
    Console.WriteLine(num + " is a prime number");
}
else
{
    Console.WriteLine(num + " is not a prime number");
}
