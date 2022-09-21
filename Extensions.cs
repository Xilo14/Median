using System.Text;

namespace Median;

public static class Extensions
{
    public static string ToPrettyString(this IEnumerable<double> values)
    {
        var sb = new StringBuilder();
        sb.Append("{ ");
        foreach (var item in values)
        {
            sb.Append(item);
            sb.Append(' ');
        }
        sb.Append('}');
        return sb.ToString();
    }
    public static bool IsOdd(this int value) => value % 2 == 0;
}

