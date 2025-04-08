using System.Net.Http.Headers;

namespace DSAAlgorithm
{
    //Lab Tree Recursion
    public class Recursion
    {
        public void CalculateRecursiveValue(int n)
        {
            if (n>0)
            {
                CalculateRecursiveValue(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                CalculateRecursiveValue(n - 1);
            }
        }
        public static void Main()
        {
            Recursion r = new Recursion();

            Console.WriteLine("Demo of Tree Recursive function");
            r.CalculateRecursiveValue(4);
            Console.ReadKey();
        }
    }
}

/*
   Output:
    Demo of Tree Recursive function
        1
        4
        1
        9
        1
        4
        1
        16
        1
        4
        1
        9
        1
        4
        1
*/