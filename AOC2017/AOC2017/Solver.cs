public class Solver
{
    public int Solve(string captcha)
    {
        var sum = 0;
        foreach (var char1 in captcha) {
            var value = int.Parse(char1.ToString());
            sum += value;
        }
        return sum;
    }
}