using System.Text;

namespace Median;

public static class EnumerableExt
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
}

