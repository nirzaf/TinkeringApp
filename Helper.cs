using static System.String;

namespace TinkeringApp;

public static class Helper
{
    public static bool IsNotNullOrWhiteSpace(this string value) => !IsNullOrWhiteSpace(value);
}