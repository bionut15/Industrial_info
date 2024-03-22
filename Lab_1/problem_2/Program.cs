byte x, y, z;

x = 2;
y = 6;
z = 3;

System.Console.WriteLine("Min =" + Math.Min(x,Math.Min(z , y)));
System.Console.WriteLine("Max =" + Math.Max(x,Math.Max(z , y)));
