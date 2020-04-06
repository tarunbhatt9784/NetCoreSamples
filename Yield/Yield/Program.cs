using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            CallFibonacci();
        }


        public static void CallFibonacci()
        {
            /*
             *GetFibonacciNumber method is called. 
             * Parameter passed is 5, hence GetFibonacciNumber will return 5 fibinacci numbers
             */
            var numbers = GetFibonacciNumber(100); // 1
            foreach (var no in numbers) // 2
            {
                Console.WriteLine(no); 
            }
        }
    
    public static IEnumerable<int> GetFibonacciNumber(int count)
        {
            int prev = -1; //3
            int next = 1;
            for (int index = 0; index < count; index++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
                yield return sum; // 4
            }
        }
    }
}
