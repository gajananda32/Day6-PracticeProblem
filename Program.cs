using System;
namespace ToBinaryCon
{
    //starting with class
    public class ToBinary
    {
        static void Main(string[] args)
        {
            //variables
            int i;
            //putting in array
            int[] arr = new int[10];
            Console.WriteLine("Enter the number to be convered: ");
            //converting string to integer
            int num = int.Parse(Console.ReadLine());
            for (i = 0; num > 0; i++)
            {
                //converting decimal to binary
                arr[i] = num % 2;
                num = num / 2;
            }
            Console.WriteLine("Binary of the number: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
