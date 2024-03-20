using System.Text.RegularExpressions;

System.Console.WriteLine("INPUT lines:");
string initial_string = Console.ReadLine();

System.Console.WriteLine("Length" + initial_string.Length);

string pattern = @"x";
string result = Regex.Replace(initial_string , pattern , "a", RegexOptions.None );
initial_string = initial_string + result;
System.Console.WriteLine("Result =" + result);

System.Console.WriteLine("Concatented string" + initial_string  );
