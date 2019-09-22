using System;

namespace Sept1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            ShiftArray(2, array);
            Console.ReadLine();
        }

        public static void ShiftArray(int n, int[] array)
        {
            // For loop to iterate element shifting
            for (var i = 0; i < n; i++)
            {
                // Define temporary array for array manipulation.
                var temp = new int[array.Length];

                // Remove first element, and shift rest element to right.
                Array.Copy(array, 1, temp, 0, array.Length - 1);

                // add first element of main array to temporary element at last index.
                temp[array.Length - 1] = array[0];

                // use new array for further iteration.
                array = temp;
            }

            // Print array element
            Array.ForEach(array, Console.WriteLine);
        }
    }
}
