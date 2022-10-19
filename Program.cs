using System.Diagnostics;
//creating new stopwatch
Stopwatch stopwatch = new Stopwatch();
//begin timing
stopwatch.Start();
for(int i = 0; i <= 5; i++)
{
    Thread.Sleep(1);
}
//stop timing
stopwatch.Stop();
//calculating time elapsed
Console.WriteLine("Time elapsed : " ,stopwatch.Elapsed);
