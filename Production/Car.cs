namespace Production;

public class Car
{
    public Car(Generator generator, Engine engine, int batteryLevel)
    {
        Generator = generator;
        Engine = engine;
        BatteryLevel = batteryLevel;
    }

    public int BatteryLevel { get; private set; }
    private Generator Generator { get; }
    private Engine Engine { get; }

    public void Drive(int kilometers)
    {
        for (var i = 1; i <= kilometers; i++)
            BatteryLevel -= Generator.GiveMeEnergyForOneKilometer() + Engine.HowMuchEnergyDoYouNeedForOneKilometer();
    }
}