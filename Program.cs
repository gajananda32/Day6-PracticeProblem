//starting with class
static class tempraturConversion
{
  static void Main(string[] args)
    {
        Console.WriteLine("Enter the value to be converted to  Fahrenheit: ");
    //converting string to integer
        int C = int.Parse(Console.ReadLine());
    //formula for celsius to feranheat
        C = (C * 9 / 5 + 32);
        Console.WriteLine(C);
        Console.WriteLine("Enter the value to be convertred to celsius: ");
        int F = int.Parse(Console.ReadLine());
    //conveting fernheat to celsius
        F = ((F - 32) * 5 / 9);
        Console.WriteLine(F);

    }
}
