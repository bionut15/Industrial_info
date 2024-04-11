int x , y , z;

System.Console.WriteLine("Enter X:");
x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter Y:");
y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter Z:");
z = Convert.ToInt32(Console.ReadLine());

int max_value = (x>y)?((x>z)?x:z):((y>z)?y:z); 
System.Console.WriteLine("Max:{0}", max_value);

int min_value = (x>y)?((y>z)?z:y):((x>z)?z:x); 
System.Console.WriteLine("Min:{0}", min_value);
