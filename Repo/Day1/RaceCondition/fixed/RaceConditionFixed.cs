using System;
using System.Threading;

public class RaceConditionFixed
{
    public static int counter = 0;
    private static readonly object lockObject = new object();

    public static void Increment()
    {
        for (int i = 0; i < 1000000; ++i)
        {
            lock (lockObject)
            {
                counter++;
            }
        }
    }


}