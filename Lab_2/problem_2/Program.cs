int n , i; 

const int a = 5 ;

System.Console.WriteLine("Enter ratio n:");
n = Console.Read();

static void DisplayArithmeticProgression(int n)
    {
        int firstTerm = 1; // You can set the first term to any value
        for (int i = 1; i < n; i++)
        {
            int term = firstTerm + (i-1) * a;
            Console.Write(", " + term);
        }
        Console.WriteLine();
    }
	Console.WriteLine("Arithmetic progression with ratio " + a + " and first " + n + " terms:");
        DisplayArithmeticProgression(n);
