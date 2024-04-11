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

static void bubbleSort(int[] arr, int n)
{
    int i, j, temp;
    bool swapped;
    for (i = 0; i < n - 1; i++) {
        swapped = false;
        for (j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                 
                // Swap arr[j] and arr[j+1]
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true;
            }
        }
        // If no two elements were
        // swapped by inner loop, then break
        if (swapped == false)
            break;
    }
}

// Function to print an array
static void printArray(int[] arr, int size)
{
    int i;
    for (i = 0; i < size; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
bubbleSort(arr, n);
Console.WriteLine("Sorted array:");
printArray(arr, n);
