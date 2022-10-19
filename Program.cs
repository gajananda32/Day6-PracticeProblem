Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine());
int total = 0;
for(int i = 1; i < num; i++)
{
    if (num % i == 0)
    {
        total += i;
    }
}
if (total == num)
{
    Console.WriteLine(num + " is a perfect number");
}
else
{
    Console.WriteLine(num + " is not a perfect number");
}
