public class ResultPrinter
{
    [Test]
    [TestCase("")]
    public void Task_1(string input)
    {
        var solver = new Solver();
        var result = solver.Solve(input);
        Console.WriteLine(result);
    }
}