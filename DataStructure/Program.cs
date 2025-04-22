using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAlgorithms
{
    class Sort
    {
        public void shellsort(int[] A, int n)
        {
            for (int gap = n/2; gap > 0; gap=gap/2)
            {
                for (int i = gap; i < n; i++)
                {
                    int gvalue = A[i];
                    int j = i - gap;
                    while (j >= 0 && A[j] > gvalue)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = gvalue;
                }
            }
        }

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.display(A, 6);
            s.shellsort(A, 6);
            Console.WriteLine("Sorted Array:");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}


/*
  int gap = n / 2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = A[i];
                    int j = i - gap;
                    while (j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = temp;
                    i = i + 1;
                }
                gap = gap / 2;
            }
 */