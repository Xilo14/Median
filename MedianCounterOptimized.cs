namespace Median;

public class MedianCounterOptimized
{
    public static IEnumerable<double> GetMedians(IEnumerable<double> numbers)
    {
        var virtualList = new VirtualSortedList();
        foreach (var num in numbers)
        {
            virtualList.Add(num);
            yield return virtualList.CurrentMedian;
        }
    }
    public struct VirtualSortedList
    {
        private readonly double[] _centerValues = new double[2];

        public int Count { get; private set; } = 0;

        public double CurrentMedian { get => Count.IsOdd() ? (_centerValues[0] + _centerValues[1]) / 2 : _centerValues[0]; }

        public VirtualSortedList() { }

        // TODO: Refactoring wouldn't hurt...
        public void Add(double value)
        {
            Count++;

            if (Count == 1)
                _centerValues[0] = value;
            else if (Count == 2)
            {
                if (value < _centerValues[0])
                {
                    _centerValues[1] = _centerValues[0];
                    _centerValues[0] = value;
                }
                else
                {
                    _centerValues[1] = value;
                }
            }
            else if (value <= _centerValues[0])
            {
                if (Count.IsOdd())
                {
                    _centerValues[1] = _centerValues[0];
                    _centerValues[0] = value;
                }
            }
            else if (value > _centerValues[0] & value <= _centerValues[1])
            {
                if (Count.IsOdd())
                {
                    _centerValues[1] = value;
                }
                else
                {
                    _centerValues[0] = value;
                }
            }
            else if (value >= _centerValues[1])
            {
                if (!Count.IsOdd())
                {
                    _centerValues[0] = _centerValues[1];
                    _centerValues[1] = value;
                }
            }
        }
    }
}
