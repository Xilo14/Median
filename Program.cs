using Median;

var input1 = new double[] { 5, 2, 1, 4, 3 };
var input2 = new double[] { 5, 23, 2, 4, 1, 4, 3, 123 };
var input3 = new double[] { 0 };
var input4 = Array.Empty<double>();

var res1 = MedianCounter.GetMedians(input1).ToArray();
var res2 = MedianCounter.GetMedians(input2).ToArray();
var res3 = MedianCounter.GetMedians(input3).ToArray();
var res4 = MedianCounter.GetMedians(input4).ToArray();

var res12 = MedianCounterOptimized.GetMedians(input1).ToArray();
var res22 = MedianCounterOptimized.GetMedians(input2).ToArray();
var res32 = MedianCounterOptimized.GetMedians(input3).ToArray();
var res42 = MedianCounterOptimized.GetMedians(input4).ToArray();


Console.WriteLine($"input1: {input1.ToPrettyString()}");
Console.WriteLine($"result1-1: {res1.ToPrettyString()}");
Console.WriteLine($"result1-2: {res12.ToPrettyString()}");
Console.WriteLine();
Console.WriteLine($"input2: {input2.ToPrettyString()}");
Console.WriteLine($"result2-1: {res2.ToPrettyString()}");
Console.WriteLine($"result2-2: {res22.ToPrettyString()}");
Console.WriteLine();
Console.WriteLine($"input3: {input3.ToPrettyString()}");
Console.WriteLine($"result3-1: {res3.ToPrettyString()}");
Console.WriteLine($"result3-2: {res32.ToPrettyString()}");
Console.WriteLine();
Console.WriteLine($"input4: {input4.ToPrettyString()}");
Console.WriteLine($"result4-1: {res4.ToPrettyString()}");
Console.WriteLine($"result4-2: {res42.ToPrettyString()}");
Console.ReadLine();
