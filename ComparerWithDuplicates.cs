namespace Median;

/// <summary>
/// By default <see cref="SortedSet"/> removes duplicates.
/// So, with this comparer, we no longer have duplicates>
/// </summary>
public class ComparerWithDuplicates : IComparer<double>
{
    public int Compare(double x, double y)
    {
        var res = x.CompareTo(y);
        return res == 0 ? 1 : res;
    }
}
