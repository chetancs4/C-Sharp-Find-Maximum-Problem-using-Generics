using System.Collections;

namespace Generics_Problem
{
    internal class Program
    {

        public static void printmax(int [] arr)
        {
            Console.WriteLine("Elements in Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            int max = arr[0];
            Console.WriteLine("Maximum integer element in the array are: ");
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("c# program to Find the Maximum Problem using Generics");
            Console.WriteLine("---------------------------------------------");

            int [] arr = { 5, 2, 9, 8, 3 };
            printmax(arr);
        }
    }
}