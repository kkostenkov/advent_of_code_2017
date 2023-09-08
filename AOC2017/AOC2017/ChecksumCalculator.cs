public class ChecksumCalculator
{
    public int Calculate(string input)
    {
        var result = 0;
        var lines = input.Split("\n");
        foreach (var line in lines) {
            result += CalcLine(line);
        }
        return result;
    }

    private int CalcLine(string input)
    {
        var values = input.Split(" ");
        var listOfValues = values.Select(s => int.Parse(s)).ToList();
        var maxValue = listOfValues.Max();
        var minValue = listOfValues.Min();
        var diff = maxValue - minValue;
        return diff;
    }
}