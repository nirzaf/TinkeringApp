using Xunit;

namespace TestingTinkeringApp;

public class ProgramTests
{
    private Program _program = new();

    [Fact]
    public void GenerateNumbers_GeneratesCorrectAmountOfNumbers()
    {
        var numbers = _program.GenerateNumbers(50);
        Assert.Equal(50, numbers.Count);
    }

    [Fact]
    public void SumNumbers_ReturnsCorrectSum()
    {
        var numbers = new List<int> {1, 2, 3, 4, 5};
        var sum = _program.SumNumbers(numbers);
        Assert.Equal(15, sum);
    }

    [Fact]
    public void FindPositiveNumbers_ReturnsOnlyPositiveNumbers()
    {
        var numbers = new List<int> {-1, 0, 1, 2, -2};
        var positiveNumbers = _program.FindPositiveNumbers(numbers);
        Assert.Equal(new List<int> {1, 2}, positiveNumbers);
    }

    [Fact]
    public void FindNegativeNumbers_ReturnsOnlyNegativeNumbers()
    {
        var numbers = new List<int> {-1, 0, 1, 2, -2};
        var negativeNumbers = _program.FindNegativeNumbers(numbers);
        Assert.Equal(new List<int> {-1, -2}, negativeNumbers);
    }
}