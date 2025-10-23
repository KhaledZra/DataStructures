internal class Program
{
    public static void Main(string[] args)
    {
        TestSortAlgorithms();
        TestSearchAlgorithms();
    }

    static void TestSortAlgorithms()
    {
        int[] data = [2, 5, 6, 7, 1, 2, 4, 2, 5, 6, 1, 2, 0, 10, 20, 11, 10, 2, 5];

        Console.WriteLine("Unsorted:");
        foreach (int number in data)
        {
            Console.Write(number + ",");
        }
        
        Console.Write("\n");
        
        // Sort algo
        SortAlgorithms.QuickSort(data, 0, data.Length - 1);
        
        Console.WriteLine("Sorted:");
        foreach (int number in data)
        {
            Console.Write(number + ",");
        }
        
        Console.Write("\n");
    }

    static void TestSearchAlgorithms()
    {
        // ------ Search logic
        int[] data = [2, 5, 6, 7, 1, 2, 4, 2, 5, 6, 1, 2, 0, 10, 20, 11, 10, 2, 5];
        int linearResult = SearchAlgorithms.LinearSearch(data, 10);
        Console.WriteLine("Linear search:");
        Console.WriteLine("Index: " + linearResult);
        Console.WriteLine("Value: " + data[linearResult]);

        int[] sortedData = [1, 2, 6, 7, 8, 9, 10, 22, 55, 66, 77];
        int binaryResult = SearchAlgorithms.BinarySearch(sortedData, 10, 0, sortedData.Length - 1);
        Console.WriteLine("Binary search:");
        Console.WriteLine("Index: " + binaryResult);
        Console.WriteLine("Value: " + sortedData[binaryResult]);
    }
}