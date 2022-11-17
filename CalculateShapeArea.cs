namespace LibraryCalculateShapeArea;

public static class CalculateShapeArea
{
    public static double CalculateCircleArea(double radius, int precision)
    {
        double area = Math.PI * (radius * radius);
        return Math.Round(area, precision, MidpointRounding.ToZero);
    }

    public static double CalculateTriangleArea(double a, double b, double c, int precision)
    {
        if ((a < 0) || (b < 0) || (c < 0))
        {
            return 0;
        }
        //Halved perimeter
        double hP = (a + b + c) / 2.0;

        // Area = Sqrt(hP * (hP - a) * (hP - b) * (hP - c))
        double area = Math.Sqrt(hP * (hP - a) * (hP - b) * (hP - c));

        // Return area with the set precision
        return Math.Round(area, precision, MidpointRounding.ToZero);
    }

    public static bool CheckIfTriangleIsRight(double a, double b, double c)
    {
        if ((a < 0) || (b < 0) || (c < 0))
        {
            return false;
        }
        
        double hypot = Math.Max(a, Math.Max(b, c));
        double smallSide = Math.Min(a, Math.Min(b, c));
        double midSide;
        
        if ((a == b) || (b == c) || (a == c))
        {
            midSide = smallSide;
        }
        else
        {
            if ((a < hypot) & (a > smallSide))
            {
                midSide = a;
            } else if ((b < hypot) & (b > smallSide))
            {
                midSide = b;
            }
            else
            {
                midSide = c;
            }    
        }
        
        if (smallSide * smallSide + midSide * midSide == hypot * hypot)
        {
            return true;
        }
        return false;
    }
}