using FluentAssertions;
using Production;
using Xunit;

namespace Tests;

public class CarTests
{
    [Theory]
    [InlineData(200, 1)]
    [InlineData(200, 10)]
    [InlineData(100, 10)]
    [InlineData(100, 5)]
    public void Car_CanDrive_SomeKilometers(int inputBatteryLevel, int kilometersToDrive)
    {
        // Arrange
        var testee = new Car(new Generator(), new Engine(), inputBatteryLevel);

        // Act
        testee.Drive(kilometersToDrive);

        // Assert
        testee.BatteryLevel.Should().BePositive();
    }
}