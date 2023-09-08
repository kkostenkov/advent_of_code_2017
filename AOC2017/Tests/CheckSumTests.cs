public class CheckSumTests
{
    [Test]
    [TestCase("5 1 9 5", ExpectedResult = 8)]
    [TestCase("7 5 3", ExpectedResult = 4)]
    [TestCase("2 4 6 8", ExpectedResult = 6)]
    [TestCase("5 1 9 5\n7 5 3\n2 4 6 8", ExpectedResult = 18)]
    public int When_GivenInput_Should_CalculateCheckSum(string input)
    {
        var checkSumCalculator = new ChecksumCalculator();
        var result = checkSumCalculator.Calculate(input);
        return result;
    }
}

