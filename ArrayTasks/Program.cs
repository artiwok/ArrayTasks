using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayInit();
            ArrayReverse();
            ArrayEvenSum();
            ArrayOddSum();
            ArrayMinValue();
            ArrayMaxValue();
            IndexOfArrayElement();
            ArrayElementAdded();
        }

        static void ArrayInit()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe array values are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");
        }

        static void ArrayReverse()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe array values are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");

            Console.Write("The reverse array is: ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");
        }

        static void ArrayEvenSum()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // Console output of even elements' values of the array and of their sum

            int sumEven = 0;

            Console.Write("Even elements' values of the array are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.WriteLine($"\n\nThe sum of even elements' values of the array is: {sumEven}\n");
        }

        static void ArrayOddSum()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // Console output of odd elements' values of the array and of their sum

            int sumOdd = 0;

            Console.Write("Odd elements' values of the array are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sumOdd += arr[i];
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.WriteLine($"\n\nThe sum of odd elements' values of the array is: {sumOdd}\n");
        }

        static void ArrayMinValue()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // The minimum value of the array

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"The minimum value of the array is: {min}\n");
        }

        static void ArrayMaxValue()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // The maximum value of the array

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"The maximum value of the array is: {max}\n");
        }

        static void IndexOfArrayElement()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Console output of the array element's index 

            Console.Write("Choose one of the above entered array elements' values: ");

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine($"The index of the array element is: {i}\n");
                }
            }
        }

        static void ArrayElementAdded()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Addition of an element to array

            int[] arrTwo = new int[num + 1];

            Console.Write("Enter additional array element's value: ");

            int element = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arrTwo[i] = arr[i];
            }

            for (int i = 0; i < arrTwo.Length; i++)
            {
                arrTwo[arrTwo.Length - 1] = element;

                Console.WriteLine($"{arrTwo[i]} ");
            }

            Console.WriteLine();
        }
    }
}
