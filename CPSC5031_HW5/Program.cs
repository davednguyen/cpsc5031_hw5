using System;

namespace CPSC5031_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heap sort");
            Console.WriteLine("Test case 1 - Happy path case [1, 5, 19, 10, 5]");
            int[] array1 = { 1, 5, 19, 10, 5 };
            Heapsort(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine("Test case 2 - Array with negative number [-1, 20, 55, 77, 13, 0]");
            int[] array2 = { -1, 20, 55, 77, 13, 0 };
            Heapsort(array2);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine("Test case 3 - Empty array []");
            int[] array3 = { };
            Heapsort(array3);
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
            Console.WriteLine("Test case 4 - Null array");
            int[] array4 = null;
            Heapsort(array4);
            Console.WriteLine(array4);

            Console.WriteLine("Test case 5 - Array with all negative numbers [-4, -3, -80, -50, -1]");
            int[] array5 = {-4, -3, -80, -50, -1};
            Heapsort(array5);
            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine(array5[i]);
            }
        }

        /// <summary>
        /// Sort the list of array
        /// </summary>
        /// <param name="list"></param>
        public static void Heapsort(int[] list)
        {
            if(list != null)
            {
                BuildHeap(list);
                for (int i = list.Length - 1; i > 0; i--)
                {
                    int value = list[0];
                    list[0] = list[i];
                    list[i] = value;
                    Heapify(list, 0);
                }
            }            
        }
        
        /// <summary>
        /// rearrange list of values in an array. 
        /// </summary>
        /// <param name="list">list of array</param>
        /// <param name="i">indext</param>
        public static void Heapify(int[] list, int i)
        {
            int left = 2 * i + 1;
            int right = 2 *  i + 1;
            int size = list.Length;
            int highest = 0;

            if (left < size && list[left] > list[i])
            {
                highest = left;
            }
            else
            {
                highest = i;
            }

            if(right < size && list[right] > list[highest])
            {
                highest = right;
            }

            if (highest != i)
            {
                int value = list[i];
                list[i] = list[highest];
                list[highest] = value;
                Heapify(list, highest);
            }
        }

        /// <summary>
        /// Build a heap out from the list of integer numbers
        /// </summary>
        /// <param name="list"></param>
        public static void BuildHeap(int[] list)
        {
            if(list != null)
            {
                int size = list.Length;
                for (int i = size / 2 - 1; i >= 0; i--)
                {
                    Heapify(list, i);
                }
            }            
        }
    }
}
