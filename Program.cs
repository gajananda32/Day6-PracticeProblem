//taking input from user﻿
Console.WriteLine("Enter the Money: ");
//converting string to integer
int n = int.Parse(Console.ReadLine());
//giving vales in array
int[] arr = { 1, 2, 5, 10, 20, 50, 100, 500, 1000 };
int count = 0;
//starting loop
for(int i = arr.Length-1; i >= 0; i--)
{
    if (arr[i] <= n)
    {
        //calculating the number of notes reqired
        count += n / arr[i];
        n %= arr[i];
    }
}
Console.WriteLine(count);


