namespace Median;

public class MedianCounter
{
    public static IEnumerable<double> GetMedians(IEnumerable<double> numbers)
    {
        var sortedSet = new SortedSet<double>(new ComparerWithDuplicates());
        
        foreach (var num in numbers)
        {
            sortedSet.Add(num);
            int index = sortedSet.Count / 2;
            // 5 7 23 54  - nums
            // 0 1 2  3   - indexes
            if (sortedSet.Count % 2 == 0)
                yield return (sortedSet.ElementAt(index) + sortedSet.ElementAt(index - 1)) / 2;
            // 5 7 23 54 121 - nums
            // 0 1 2  3  4   - indexes
            else
                yield return sortedSet.ElementAt(index);
        }
    }
}
