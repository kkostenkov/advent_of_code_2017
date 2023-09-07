public class Tests
{
    [Test]
    [TestCase("1122", 3)]
    public void When_GivenCaptcha_Should_CalculateSum(string captcha, int expectedResult)
    {
        var solver = new Solver();
        var result = solver.Solve(captcha);
        Assert.AreEqual(expectedResult, result);
    }
}