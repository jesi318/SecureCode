using System;

namespace SecureCode.Day1.IntegerOverflow.Vulnerable
{
    public class IntOverflow
    {
        public static int Add(int a, int b)
        {
            if(a>0 && b>0 && a > int.MaxValue - b || a<0 && b<0 && a < int.MinValue - b)
            {
                throw new OverflowException("Integer overflow");
            }
            return a + b;
        }

    }
}