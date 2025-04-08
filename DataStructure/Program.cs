using System.Net.Http.Headers;

namespace DSAAlgorithm
{
    //Lab Tail Recursion
    public class Recursion
    {
        public void CalculateRecursiveValue(int n)
        {
            if (n>0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateRecursiveValue(n - 1);
            }
        }
        public static void Main()
        {
            Recursion r = new Recursion();

            Console.WriteLine("Demo of Tail Recursive function");
            r.CalculateRecursiveValue(4);
            Console.ReadKey();
        }
    }
}

/*
   Output:
    Demo of Tail Recursive function
    16
    9
    4
    1
*/