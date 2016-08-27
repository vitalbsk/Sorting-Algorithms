using System;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10] { 3, 6, 1, 8, 2, 5, 9, 2, 7, 4 };

            //Bubble Sort
            SortArray<int>.BubbleSort(array);
            Console.Write("Result of Bubble Sort:");
            for(int i = 0; i < array.Length; i++){
                Console.Write(array[i] + " ");
            } 
            Console.WriteLine();

            //Insertion Sort
            SortArray<int>.InsertionSort(array);
            Console.Write("Result of Insertion Sort:");
            for(int i = 0; i < array.Length; i++){
                Console.Write(array[i] + " ");
            } 
            Console.WriteLine();
            
            //Selection Sort
            SortArray<int>.SelectionSort(array);
            Console.Write("Result of Selection Sort:");
            for(int i = 0; i < array.Length; i++){
                Console.Write(array[i] + " ");
            }        
        }
    }
}
