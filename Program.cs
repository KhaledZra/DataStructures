internal class Program
{
    public static void Main(string[] args)
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
}
