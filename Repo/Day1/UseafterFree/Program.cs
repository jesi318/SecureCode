// See https://aka.ms/new-console-template for more information
class Program
{
    static void ProcessData(SensorData data)
    {

        if (data != null)
        {
            data.PrintTemperature();
        }
        else
        {
            Console.WriteLine("Invalid SensorData reference.");
        }
    }

    static void Main()
    {
        SensorData sensor1 = new SensorData(25);
        ProcessData(sensor1);
        sensor1 = null; 
        
        GC.Collect(); 
        GC.WaitForPendingFinalizers();

        SensorData sensor2 = new SensorData(15);
        ProcessData(sensor1);
        sensor2 = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
