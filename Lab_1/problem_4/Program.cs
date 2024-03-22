namespace Program
{
	public enum Months{
		January,
		February,
		March,
		April,
		May,
		June,
		July,
		August,
		September,
		Octomber,
		November,
		December
	}
	public static class Program{
	static void Main(string[] args)
	{
		int myNum1 = (int) Months.February +1;
		int myNum2 = (int) Months.August +1;

		System.Console.WriteLine(myNum1 );
		System.Console.WriteLine(myNum2);
	    
	}
}
    
}
