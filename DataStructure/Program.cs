using System.Net.Http.Headers;

namespace DSAAlgorithm
{
    //Lab Head Recursion
    public class Recursion
    {
        public void CalculateRecursiveValue(int n)
        {
            if (n>0)
            {
                CalculateRecursiveValue(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }
        public static void Main()
        {
            Recursion r = new Recursion();

            Console.WriteLine("Demo of Head Recursive function");
            r.CalculateRecursiveValue(4);
            Console.ReadKey();
        }
    }
}

/*
   Output:
   Demo of Head Recursive function
   1
   4
   9
   16
*/