namespace AbstractClasses;

public class XorArray : ArrayAbstract
{
    private readonly int[] _array;
    
    public XorArray(int[] sourceArray)
    {
        _array = sourceArray;
    }

    public override double[] ForEach()
    {
        var arraySize = _array.Length;
        var temperanceArray = new double[arraySize];
        _array.CopyTo(temperanceArray, 0);

        for (var index = 0; index < arraySize; index++)
            temperanceArray[index] = Math.Sqrt(temperanceArray[index]);


        return temperanceArray;
    }

    public override int[] Sum(int[] otherArray)
    {
        var temperanceArray = new int[_array.Length + otherArray.Length];

        for (var index = 0; index < _array.Length; index++)
            temperanceArray[index] = _array[index];

        for (var index = _array.Length; index < temperanceArray.Length; index++)
            temperanceArray[index] = otherArray[index - _array.Length];

        var resultArray = temperanceArray
            .Where(element => !_array.Contains(element) || !otherArray.Contains(element))
            .ToArray();

        return resultArray;
    }
}