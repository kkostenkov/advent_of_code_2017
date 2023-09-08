public class CheckSumTests
{
    [Test]
    [TestCase("5\t1\t9\t5", ExpectedResult = 8)]
    [TestCase("7\t5\t3", ExpectedResult = 4)]
    [TestCase("2\t4\t6\t8", ExpectedResult = 6)]
    [TestCase("5\t1\t9\t5\n7\t5\t3\n2\t4\t6\t8", ExpectedResult = 18)]
    public int When_GivenInput_Should_CalculateCheckSum(string input)
    {
        var checkSumCalculator = new ChecksumCalculator();
        var result = checkSumCalculator.Calculate(input);
        return result;
    }

    [Test]
    [TestCase("../../../../Input/oneLine.txt", ExpectedResult = "8")]
    public string When_GivenPath_Should_ReadContents(string path)
    {
        var fileReader = new FileReader();
        var result = fileReader.Read(path);
        return result;
    }
    
    [Test]
    public void PrintResult_Task2()
    {
        var text = new FileReader().Read("../../../../Input/task2.txt");
        var checkSumCalculator = new ChecksumCalculator();
        var result = checkSumCalculator.Calculate(text);
        Console.WriteLine(result);
    }
}