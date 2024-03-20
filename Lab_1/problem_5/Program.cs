public class Circle
{
  private int x;
  private int y;
  private uint radius;

  public void SetValues(int xVal, int yVal, uint radiusVal)
  {
    if (radiusVal > 0)
    {
      x = xVal;
      y = yVal;
      radius = radiusVal;
    }
    else
    {
      throw new ArgumentOutOfRangeException(nameof(radiusVal), radiusVal, "Radius must be positive.");
    }
  }

  public void Display()
  {
    Console.WriteLine($"Center: ({x}, {y})");
    Console.WriteLine($"Radius: {radius}");
  }

  // Method to calculate and return the area of the circle
  public double GetArea()
  {
    const double PI = 3.14159;
    return PI * radius * radius;
  }
}

public static class Program
{
  static void Main(string[] args)
  {
    // Create a Circle object
    Circle circle = new Circle();

    // Set values (example with user input)
    Console.Write("Enter x-coordinate: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Enter y-coordinate: ");
    int y = int.Parse(Console.ReadLine());

    Console.Write("Enter radius: ");
    uint radius = uint.Parse(Console.ReadLine());

    try
    {
      circle.SetValues(x, y, radius);
    }
    catch (ArgumentOutOfRangeException e)
    {
      Console.WriteLine(e.Message);
      return; // Exit program if radius is invalid
    }

    // Display circle information
    circle.Display();

    // Calculate and display area
    double area = circle.GetArea();
    Console.WriteLine($"Area: {area:F2}"); // Format area with two decimal places
  }
}

