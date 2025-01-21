using System.Diagnostics;
using System.Linq.Expressions;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Enter an array size");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a max item size");
            int maxitemsize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a min item size");
            int minitemsize = Convert.ToInt32(Console.ReadLine());
            int[] thisarray = CreateArray(arraysize,n, minitemsize, maxitemsize );
            while (true) {
                menu();
                         }
        }
        static int[] CreateArray(int size, Random r, int min, int max)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++) 
            { 
             array[i] = r.Next(min, max);
            }
            return array;
        }

        static void menu()
        {

        }
        
        static int[] BubbleSort(int[] a)
        {
            
            int x = 0;
            bool swaps = false;
            int count = 0;
            
            do
            {
                swaps = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        x = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = x;
                        swaps = true;
                    }
                    count++;
                }
            } while (swaps);
            
            return a;
        }
        static int[] Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
            return a;
        }
        static int[] MergeSortRecursive(int[] a, int low, int high)
        {
            int[] answer = new int[high + 1];
            if (low < high)
            {
                
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                answer = Merge(a, low, mid, high);
            }
            return answer;
                
        }
        static bool LinearSearch(int[] a, int numToFind)
        {

        }
        static bool BinarySearch(int[] a, int numToFind)
        {
            
        }
            
    }
}
