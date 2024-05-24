using System;

class Program
{
    static void Main()
    {
        // Read the array from the console
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Call the method to modify the array
        ModifyArray(array);

        // Display the resulting array
        Console.WriteLine("Modified array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void ModifyArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                // Even index
                array[i]++;
            }
            else
            {
                // Odd index
                array[i]--;
            }
        }
    }
}
