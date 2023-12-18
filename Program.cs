using static System.Console;

WriteLine("Liq Practice Tasks");

// generate a list of int with 100 elements include negative numbers
var random = new Random();
var numbers = new List<int>();
for (int i = 0; i < 50; i++)
{
    numbers.Add(random.Next(-100, 100));
}

// 1. find the sum of all numbers using linq
var sum = numbers.Sum();
WriteLine($"Sum: {sum}");

// 2. find all positive numbers
var positiveNumbers = numbers.Where(n => n > 0);
int[] enumerable = positiveNumbers as int[] ?? positiveNumbers.ToArray();
WriteLine($"Positive numbers: {string.Join(", ", enumerable)}");

//number of all positive numbers
var positiveNumbersCount = enumerable.Length;
WriteLine($"Positive numbers count: {positiveNumbersCount}");


// 3. find all negative numbers
var negativeNumbers = numbers.Where(n => n < 0);
int[] enumerable1 = negativeNumbers as int[] ?? negativeNumbers.ToArray();
WriteLine($"Negative numbers: {string.Join(", ", enumerable1)}");

ReadLine();





