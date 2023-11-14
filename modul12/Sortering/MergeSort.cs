namespace Sortering;

public static class MergeSort
{

    public static void Sort(int[] array)
    {
        _mergeSort(array, 0, array.Length - 1);
    }

    private static void _mergeSort(int[] array, int l, int h)
    {
        if (l < h)
        {
            int m = (l + h) / 2;
            _mergeSort(array, l, m);
            _mergeSort(array, m + 1, h);
            Merge(array, l, m, h);
        }
    }

    private static void Merge(int[] array, int low, int middle, int high)
    {
     
        // Initialiser hjælpearrays
        int helperArrayLengthLeft = middle - low + 1;
        int helperArrayLengthRight = high - middle;
        
        int[] helperArrayLeft = new int[helperArrayLengthLeft];
        int[] helperArrayRight = new int[helperArrayLengthRight];
        
        // Kopier data til hjælpearrays
        Array.Copy(array, low, helperArrayLeft, 0, helperArrayLengthLeft);
        Array.Copy(array, middle + 1, helperArrayRight, 0, helperArrayLengthRight);
        
        // Sammenlign og kopier tilbage til oprindelige array
        int LeftIndex = 0;
        int RightIndex = 0;
        int CurrentIndex = low;
        
        // merge hjælpearrays tilbage til oprindelige array
        while (LeftIndex < helperArrayLengthLeft && RightIndex < helperArrayLengthRight)
        {
            if (helperArrayLeft[LeftIndex] <= helperArrayRight[RightIndex])
            {
                array[CurrentIndex] = helperArrayLeft[LeftIndex];
                LeftIndex++;
            }
            else
            {
                array[CurrentIndex] = helperArrayRight[RightIndex];
                RightIndex++;
            }
            CurrentIndex++;
        }
        
        // kopier resterende elementer fra hjælpearray til oprindelige array altså ryd op
        while (LeftIndex < helperArrayLengthLeft)
        {
            array[CurrentIndex] = helperArrayLeft[LeftIndex];
            LeftIndex++;
            CurrentIndex++;
        }
        
        while (RightIndex < helperArrayLengthRight)
        {
            array[CurrentIndex] = helperArrayRight[RightIndex];
            RightIndex++;
            CurrentIndex++;
        }
        
    }

}
