using System;

namespace CodeAnalysisinVS_Using_RoslynAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a N value to print");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while(i<n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
