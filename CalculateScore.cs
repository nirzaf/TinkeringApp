
public record struct CalculateScore
{
    private int Score { get; set; }

    public CalculateScore(int score)
    {
        Score = score;
    }

    public void AddScore(int score)
    {
        Score += score;
    }
    
    public int GetScore()
    {
        return Score;
    }
}

record struct GlobalConstants
{
    public const int MaxScore = 100;
    public const int MinScore = 0;
}

public static class GlobalConstant
{
    public const int MaxScore = 100;
    public const int MinScore = 0;
}

public record struct Location(double Latitude, double Longitude);


