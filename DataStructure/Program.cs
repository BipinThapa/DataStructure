using System.Net.Http.Headers;

namespace DSAAlgorithm
{
    //Lab Iteration and Recursion
    public class Recursion
    {
        public void CalculateIterativeValue(int n)
        {
            while (n>0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

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

            Console.WriteLine("Demo of Iterative function");
            r.CalculateIterativeValue(4);

            Console.WriteLine("Demo of Recursive function");
            r.CalculateRecursiveValue(4);
            Console.ReadKey();
        }
    }
}
