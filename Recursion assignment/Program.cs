namespace Recursion_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = RecursiveSum(n, m);
            Console.WriteLine(sum);

            Console.WriteLine("Division");
            Console.WriteLine("Enter your number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int divisions = CountDivisions(num);
            Console.WriteLine("Total number of divisions: " + divisions);
        }

        static int RecursiveSum(int n, int m)
        {
            if (n == m)
            
                return n;
            
            else
            
                return n + RecursiveSum(n + 1, m);
            
        }

        static int CountDivisions(int num)
        {
            int count = 0;
            while (num % 2 == 0)
            {
                num /= 2;
                count++;
            }
            return count;
        }
    }
}
