using System.Globalization;

namespace Tests;

public static class Calculator
{
    public static float Calculate(int[] numbers)
    {
        var halfSum = 0;
        foreach (var number in numbers)
        {
            halfSum += number / 2;
        }

        return halfSum;
    }
    
    public static float ParseFloat(string number)
    {
        return float.Parse(number, CultureInfo.InvariantCulture);
    }
}