public static class SearchAlgorithms
{
    // Unsorted list
    public static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target) return i;
        }

        return -1;
    }

    // Requires Sorted list
    public static int BinarySearch(int[] array, int target, int start, int end)
    {
        int middle = (start + end) / 2;

        // Safety check
        if (start > end) return -1;
        // Middle
        if (array[middle] == target) return middle;
        // Left side
        if (target < array[middle])
            return BinarySearch(array, target, start, middle - 1);
        // Right side
        return BinarySearch(array, target, middle + 1, end);
    }
}