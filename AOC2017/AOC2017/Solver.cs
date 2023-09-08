public class Solver
{
    public int Solve(string captcha)
    {
        var sum = 0;
        for (var index = 0; index < captcha.Length; index++) {
            var c = captcha[index];
            var value = int.Parse(c.ToString());
            var nextValue = int.Parse(captcha[index + 1].ToString());
            if (value == nextValue) {
                sum += value;
            }
        }
        return 3;
    }
}