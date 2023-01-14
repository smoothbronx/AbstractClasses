namespace ConsoleApp1;

using AbstractClasses;

public static class Program
{
    private static void TestSortArray()
    {
        Console.WriteLine("SortArray");
        var sortArray = new SortArray(new[] { 1, 3, 2 });
        
        var resultArray = sortArray.Sum(new[] { 2, 4, 3 });
        Console.WriteLine($"\tResult from Sum method: [{string.Join(", ", resultArray)}]");
        
        var sortedArray = new SortArray(resultArray).ForEach();
        Console.WriteLine($"\tResult from ForEach method: [{string.Join(", ", sortedArray)}]");
    }

    private static void TestXorArray()
    {
        Console.WriteLine("XorArray:");
        var xorArray = new XorArray(new[] { 1, 2, 3 });
        
        var resultArray = xorArray.Sum(new[] { 2, 4, 3 });
        Console.WriteLine($"\tResult from Sum method: [{string.Join(", ", resultArray)}]");
        
        var sqrtArray = new XorArray(resultArray).ForEach();
        Console.WriteLine($"\tResult from ForEach method: [{string.Join(", ", sqrtArray)}]");
    }

    public static void Main(string[] args)
    {
        TestSortArray();
        Console.WriteLine();
        TestXorArray();
    }
}