using System.Collections;

namespace Generics_Problem
{
    internal class Program
    {

        /*public static void printmax(int [] arr)
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
        }*/

        public static void Printmaxf(float[] arr2 )
        {
            Console.WriteLine("Elements in array: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();

            float max = arr2[0];
            Console.WriteLine("Maximum Float in the given array are: ");
            for(int i = 1; i < arr2.Length; i++)
            {
                if (arr2[i] > max)
                {
                    max = arr2[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine();    
        }

        static void Main(string[] args)
        {
            Console.WriteLine("c# program to Find the Maximum Problem using Generics");
            Console.WriteLine("---------------------------------------------");

            /*int [] arr = { 5, 2, 9, 8, 3 };
            printmax(arr);*/

            float[] arr2 = { 2.1F, 3.5F, 4.9F };
            Printmaxf(arr2);

        }

        
    }
}