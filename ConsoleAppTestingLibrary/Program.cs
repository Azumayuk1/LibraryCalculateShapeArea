using LibraryCalculateShapeArea;

Console.WriteLine(
    "Calculate circle area using radius (1) or triangle area using it's sides (2), or check if triangle is right (3)?");

int choice = 0;
try
{
    choice = Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Not a correct choice.");
    Console.WriteLine(e.Message);
}

switch (choice)
{
    case 1:
        try
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Circle area: ");
            Console.WriteLine(CalculateShapeArea.CalculateCircleArea(radius, 1));
        }
        catch (Exception e)
        {
            Console.WriteLine("Incorrect input.");
            Console.WriteLine(e.Message);
        }
        break;
    case 2:
        try
        {
            Console.WriteLine("Enter triangle sides in order a, b, c; and then precision:");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double c = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            int linePrecision = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Triangle area: ");
            Console.WriteLine(CalculateShapeArea.CalculateTriangleArea(a, b, c, linePrecision));
        }
        catch (Exception e)
        {
            Console.WriteLine("Incorrect input.");
            Console.WriteLine(e.Message);
        }
        break;
    case 3:
        try
        {
            Console.WriteLine("Enter triangle sides in order a, b, c:");
            double aRightCheck = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double bRightCheck = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            double cRightCheck = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Triangle is right?: ");
            Console.WriteLine(CheckShapeAttributes.CheckIfTriangleIsRight(aRightCheck, bRightCheck, cRightCheck));
        }
        catch (Exception e)
        {
            Console.WriteLine("Incorrect input.");
            Console.WriteLine(e.Message);
        }
        break;
    default:
        Console.WriteLine("Unknown choice. Choose between 1, 2 or 3.");
        break;
}