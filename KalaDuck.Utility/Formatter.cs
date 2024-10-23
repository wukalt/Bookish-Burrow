namespace KalaDuck.Utility;

public static class Formatter
{
    public static string GeneratePriceFormat(this decimal price) => $"{price:C2}";
    public static string GeneratePointFormat(this float point) => $"{point:C2}";
}