namespace BookishBurrow.Utility;

public static class Formatter
{
    public static string GeneratePriceFormat(this decimal price)
        => $"{price:C2}";

    public static string GeneratePointFormat(this float point)
        => $"{point:N1}";

    public static string GenerateShortDescription(this string description)
    {
        string generatedDescription = (description.Length <= 250) ? 
            $"{description}..." : $"{description.Substring(0, 250)}...";

        return generatedDescription;
    }
}