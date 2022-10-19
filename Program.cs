Console.WriteLine("Enter the Money: ");
int n = int.Parse(Console.ReadLine());
int[] arr = { 1, 2, 5, 10, 20, 50, 100, 500, 1000 };
int count = 0;
for(int i = arr.Length-1; i >= 0; i--)
{
    if (arr[i] <= n)
    {
        count += n / arr[i];
        n %= arr[i];
    }
}
Console.WriteLine(count);

