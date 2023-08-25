public class Tests
{
    [Test]
    [TestCase("1122", 3)]
    [TestCase("1111", 4)]
    [TestCase("1234", 0)]
    [TestCase("91212129", 9)]
    public void When_GivenCaptcha_Should_CalculateNextDigitSum(string captcha, int expectedResult)
    {
        var solver = new Solver();
        var result = solver.SolveNextDigit(captcha);
        Assert.AreEqual(expectedResult, result);
    }
    
    [Test]
    [TestCase("1122", 6)]
    // [TestCase("1111", 4)]
    // [TestCase("1234", 0)]
    // [TestCase("91212129", 9)]
    public void When_GivenCaptcha_Should_CalculateOppositeDigitSum(string captcha, int expectedResult)
    {
        var solver = new Solver();
        var result = solver.SolveOppositeDigit(captcha);
        Assert.AreEqual(expectedResult, result);
    }
}