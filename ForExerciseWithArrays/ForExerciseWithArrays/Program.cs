using System;

namespace ForExerciseWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = ReadNumber("Dimensiunea vectorului=");

            int[] array = ReadArray(length);

            PrintArray(array);

            PrintReversedArray(array);

            Console.WriteLine();

            Console.WriteLine($"Sum of elements={SumArrayElements(array)}");
        }

        /// <summary>
        /// Reads a number form the console.
        /// <code>sample code</code>
        /// </summary>
        /// <param name="label">The label to display so that user knows what value to input.</param>
        /// <returns>A number representing the <see cref="int"/> value of the input.</returns>
        private static int ReadNumber(string label)
        {
            if (string.IsNullOrEmpty(label))
            {
                label = "Please enter a numeric value=";
            }

            Console.Write(label);
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                throw new Exception($"Input '{input}' does not represent a valid number");
            }

            return result;
        }

        private static int[] ReadArray(int length)
        {
            if (length < 0)
            {
                Console.WriteLine($"You have specified a negative length for the array ({length}), we will assume you mean an empty array!");
                return new int[0];
            }

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                int element = ReadNumber($"Please enter element[{i}]=");

                array[i] = element;
            }

            return array;
        }

        private static void PrintArray(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return;
            }

            Console.WriteLine();
            Console.Write("Array: [");
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                Console.Write($"{element}");

                if (i < array.Length - 1)
                {
                    Console.Write($",");
                }
            }

            Console.Write("]");
        }

        private static void PrintReversedArray(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return;
            }

            Console.WriteLine();
            Console.Write("Reversed Array: [");
            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                int element = array[i];
                Console.Write($"{element}");

                if (i > 0)
                {
                    Console.Write($",");
                }
            }

            Console.Write("]");
        }

        private static int SumArrayElements(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return 0;
            }

            int i, sum;
            for (i = 0, sum = 0; i < array.Length; sum += array[i], i++);

            return sum;
        }

        private static int SumArrayElements2(int[] array)
        {
            if (array is null)
            {
                Console.WriteLine("Array argument is null!");
                return 0;
            }

            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }

            return sum;
        }
    }
}
