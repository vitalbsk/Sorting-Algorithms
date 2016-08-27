using System;

public static class SortArray<T>  where T: IComparable
{
    #region BubbleSort
    //Complexity	Best Case	Average Case	Worst Case
    //Time	            O(n)	       O(n2)	   O(n2)
    //Space	            O(1)	       O(1)	       O(1)
    public static void BubbleSort(T[] array)
    {
        if(array == null){
            throw new ArgumentNullException(nameof(array));
        }
              
        bool swapped;
        do {
            swapped = false;
            for(int currIndex = 0; currIndex< array.Length-1; currIndex++){
                if(array[currIndex].CompareTo(array[currIndex + 1]) > 0){
                    Swap(array, currIndex, currIndex + 1);
                    swapped = true;
                }
            }   
        } while(swapped);
    }   

    #endregion

    #region InsertionSort
    //Complexity	Best Case	Average Case	Worst Case
    //Time	            O(n)	       O(n2)	   O(n2)
    //Space	            O(1)	       O(1)	       O(1)
    public static void InsertionSort(T[] array){
        if(array == null){
            throw new ArgumentNullException(nameof(array));
        }
        
        for(int i = 1; i < array.Length; i++){
           if(array[i].CompareTo(array[i - 1]) < 0)
           {
               int insertIndex = GetInsertIndex(array, i);
               Insert(array, insertIndex, i);
           }
        }         
    }

    private static int GetInsertIndex(T[] array, int currIndex){
         for(int g = 0; g < currIndex; g++){
                if(array[g].CompareTo(array[currIndex]) > 0){
                    return g;
                }
            }

        throw new InvalidOperationException("The insertion index was not found");
    }

    private static void Insert(T[] itemArray, int indexInsertingAt, int indexInsertingFrom)
    {             
        T temp = itemArray[indexInsertingAt];
        itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];
    
        for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
        {
            itemArray[current] = itemArray[current - 1];
        }
    
        itemArray[indexInsertingAt + 1] = temp;
    }
    #endregion

      #region SelectionSort
    //Complexity	Best Case	Average Case	Worst Case
    //Time	            O(n)	       O(n2)	   O(n2)
    //Space	            O(1)	       O(1)	       O(1)
    public static void SelectionSort(T[] array){
        if(array == null){
            throw new ArgumentNullException(nameof(array));
        }

        int currIndex = 0;
        while(currIndex < array.Length){
            var indexFrom = GetIndexMinElement(array, currIndex);
            if(currIndex != indexFrom){
                Swap(array, currIndex, indexFrom);
            }
            currIndex++;
        }
    }

    private static int GetIndexMinElement(T[] array, int satrtIndex){
        int indexFrom = satrtIndex;
        for(int i = satrtIndex + 1; i < array.Length; i++){
            if(array[indexFrom].CompareTo(array[i]) > 0)
            {
                indexFrom = i;
            }
        }
        return indexFrom;
        
    }
    #endregion

     #region MergeSort
    //Complexity	Best Case	Average Case	Worst Case
    //Time	        O(n log n)	O(n log n)	    O(n log n)
    //Space	           O(n)	       O(n)	       O(n)
    public static void MergeSort(T[] array){
        if(array == null){
            throw new ArgumentNullException(nameof(array));
        }

        int middleIndex = array.Length % 2;
       // T[] left = Array.Copy()
      //  MergeSort(left);
      //  MergeSort(right);
      //  MergeSort(left, right)
    }

    private static void Merge(T[] array){
       // int indexFrom = satrtIndex;
        //for(int i = satrtIndex + 1; i < array.Length; i++){
         //   if(array[indexFrom].CompareTo(array[i]) > 0)
        //    {
       //         indexFrom = i;
       //     }
       // }
       // return indexFrom;
        
    }
    #endregion

    private static void Swap(T[] array, int left, int right)
    {
        if (left != right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}

