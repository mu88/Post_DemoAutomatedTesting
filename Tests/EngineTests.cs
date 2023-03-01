using FluentAssertions;
using Production;
using Xunit;

namespace Tests;

public class EngineTests
{
    [Fact]
    public void Engine_ShouldConsumeSomeEnergy()
    {
        // Arrange
        var testee = new Engine();
        
        // Act
        var result = testee.HowMuchEnergyDoYouNeedForOneKilometer();

        // Assert
        result.Should().BePositive();
    }
}