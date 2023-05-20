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

        /*public static void Printmaxf(float[] arr2 )
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
        }*/

       /* public static void Printmaxs(string[] arr3)
        {
            Console.WriteLine("Elements in Array: ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            Console.WriteLine();
            
            string max = arr3[0];
            for (int i = 1; i < arr3.Length; i++)
            {
                if (arr3[i].CompareTo(max) > 0)
                {
                    max = arr3[i];
                }
            }
            Console.WriteLine("Maximum string in the given array are: "+max);
        }*/

        //using generics
        public static T maxOfValues<T> (T a1, T a2, T a3) where T : IComparable<T>
        {
            T max = a1;
            if (a2.CompareTo(max) > 0)
                max = a2;
            if (a3.CompareTo(max) > 0)
                max = a3;
            return max;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("c# program to Find the Maximum Problem using Generics");
            Console.WriteLine("---------------------------------------------");

            /*int [] arr = { 5, 2, 9, 8, 3 };
            printmax(arr);*/

            /*float[] arr2 = { 2.1F, 3.5F, 4.9F };
            Printmaxf(arr2);*/

           /* string[] arr3 = { "abcd", "xyz", "pqrstu" };
            Printmaxs(arr3);*/

            Console.WriteLine("The maximum value between the three integer is : " + maxOfValues(3, 8, 5) + "\n");
            Console.WriteLine("The maximum value between the three float is : " + maxOfValues(1.5f, 3.56f, 5.87f) + "\n");
            Console.WriteLine("The maximum value between the three string is : " + maxOfValues("abc", "pqr", "xyz"));

        }

        
    }
}