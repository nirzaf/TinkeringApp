public class Program
{
    public static void Main(string[] args)
    {
        var program = new Program();
        var numbers = program.GenerateNumbers(50);
        var sum = program.SumNumbers(numbers);
        var positiveNumbers = program.FindPositiveNumbers(numbers);
        var negativeNumbers = program.FindNegativeNumbers(numbers);
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Positive numbers: {string.Join(", ", positiveNumbers)}");
        Console.WriteLine($"Negative numbers: {string.Join(", ", negativeNumbers)}");
    }
    
    private readonly Random _random = new();

    public List<int> GenerateNumbers(int count)
    {
        var numbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            numbers.Add(_random.Next(-100, 100));
        }
        return numbers;
    }

    public int SumNumbers(List<int> numbers)
    {
        return numbers.Sum();
    }

    public List<int> FindPositiveNumbers(List<int> numbers)
    {
        return numbers.Where(n => n > 0).ToList();
    }

    public List<int> FindNegativeNumbers(List<int> numbers)
    {
        return numbers.Where(n => n < 0).ToList();
    }
}
