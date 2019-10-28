using System;

namespace Recursion
{
    public static class RecursiveFactorial
    {
        public static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            int currentFactorial = Factorial(num - 1);
            return num * currentFactorial;
        }
    }
}
