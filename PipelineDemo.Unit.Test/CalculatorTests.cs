using FluentAssertions;
using Xunit;

namespace PipelineDemo.Unit.Test;

public class CalculatorTests
{
    private readonly Calculator _sut;

    public CalculatorTests()
    {
        _sut = new Calculator();
    }
    
    [InlineData(3, -2, 1)]
    [InlineData(0, -8, -8)]
    [InlineData(1, 2, 3)]
    [Theory]
    public void Add_ShouldReturnAdditionOfTwoInputs_Whenever(int a, int b, int expected)
    {
        // Arrange

        // Act
        var actual = _sut.Add(a, b);

        // Assert
        actual.Should().Be(expected);
    }
}