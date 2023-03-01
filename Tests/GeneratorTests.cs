using FluentAssertions;
using Production;
using Xunit;

namespace Tests;

public class GeneratorTests
{
    [Fact]
    public void Generator_Should_ProduceSomeEnergy()
    {
        // Arrange
        var testee = new Generator();

        // Act
        var result = testee.GiveMeEnergyForOneKilometer();

        // Assert
        result.Should().BePositive();
    }
}