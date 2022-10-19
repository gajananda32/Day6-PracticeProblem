Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        count++;
    }
}
if (count == 2)
{
    Console.WriteLine(num + " is a prime number");
}
else
{
    Console.WriteLine(num + " is not a prime number");
}
