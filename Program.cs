Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int rev = 0;
int rem = 0;
while (num > 0)
{
    rem = num % 10;
    rev = rev * 10 + rem;
    num = (num / 10);
}
Console.WriteLine(rev);
