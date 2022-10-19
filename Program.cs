//variables
int a = 0;
int b=1;
int c=0;
Console.WriteLine("Fibonacci Series : ");
Console.WriteLine(a + " " + b + " ");
//intilizing for loop
for(int i = 0; i <= 10; i++)
{
    c = a + b;
    Console.WriteLine(c);
    a = b;
    b = c;
}



