using System;
using System.Threading;

public class RaceConditionVuln
{
    public static int counter = 0;

    public static void Increment()
    {
        for (int i = 0; i < 1000000; ++i)
        {
            counter++;
        }
    }


}