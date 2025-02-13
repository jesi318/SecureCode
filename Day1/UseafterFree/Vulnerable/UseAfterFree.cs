using System;

class SensorData
{
    public int Temperature { get; private set; }

    public SensorData(int temp)
    {
        Temperature = temp;
        Console.WriteLine($"SensorData created with temperature: {Temperature}");
    }

    public void PrintTemperature()
    {
        Console.WriteLine($"Current temperature: {Temperature}");
    }

    ~SensorData()
    {
        Console.WriteLine("SensorData object destroyed!");
    }
}


