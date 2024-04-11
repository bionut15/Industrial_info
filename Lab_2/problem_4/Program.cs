System.Console.WriteLine("Enter the n elements:");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

// Input values for the array
Console.WriteLine("Enter the values of the array:");
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter value for element {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

// Determine minimum and maximum values
int min = arr[0];
int max = arr[0];

for (int i = 1; i < n; i++)
{
    if (arr[i] < min)
        min = arr[i];

    if (arr[i] > max)
        max = arr[i];
}

// Display minimum and maximum values
Console.WriteLine($"Minimum value in the array: {min}");
Console.WriteLine($"Maximum value in the array: {max}");

Console.ReadLine();
