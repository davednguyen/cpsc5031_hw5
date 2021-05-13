using System;

namespace CPSC5031_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] arr = { 12, 11, 13, 5, 6, 7 };
            //int n = arr.Length;

            //SortGeeksForGeeks(arr);
            //Console.WriteLine("Sorted array is");
            //printArray(arr);

            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Build a Heap");
            int[] arr2 = { 12, 11, 13, 5, 6, 7 };
            //Heapify(arr2, 6);
            //printArray(arr2);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sort a Heap");
            HeapSort(arr2, 6);
            printArray(arr2);
        }
        
        public static void Heapify(int[] list, int count)
        {
            //swap first element and last element
            int start = count - 1;
            while (start >= 0)
            {
                SiftDown(list, start, count - 1);
                start--;
            }
        }

        public static void SiftDown(int[] list, int start, int end)
        {
            int root = start;
            int child = 0; 
            while (root <= end)
            {
                int swap = root;
                
                if(list[swap] < list[child])
                {
                    swap = child;
                    
                }
                if (list[child + 1] <= list[end] && list[swap] < list[child + 1])
                {
                    swap = child + 1;
                }

                if (swap == root)
                {
                    return;
                }
                else
                {
                    int rootValue = list[root];
                    int swapValue = list[swap];
                    list[root] = swapValue;
                    list[swap] = rootValue;
                }
                child++;
                root++;
            }
        }

        public static void HeapSort(int[] list, int count)
        {
            Heapify(list, count);
            int end = count - 1;
            while (end > 0)
            {
                int largest = list[0];
                int swapValue = list[end];
                list[0] = swapValue;
                list[end] = largest;              
                end--;
                SiftDown(list, 0, end);                
            }
        }

        /////////////////////////////------------------------------- codes from Geeks for Geeks---------------------------//////////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public static void SortGeeksForGeeks(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                HeapifyGeeksForGeeks(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                HeapifyGeeksForGeeks(arr, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap
        public static void HeapifyGeeksForGeeks(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                HeapifyGeeksForGeeks(arr, n, largest);
            }
        }

        /* A utility function to print array of size n */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }
    }
}
