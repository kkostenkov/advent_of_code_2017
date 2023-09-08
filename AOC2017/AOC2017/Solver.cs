public class Solver
{
    public int Solve(string captcha)
    {
        var sum = 0;
        for (var index = 0; index < captcha.Length; index++) {
            var c = captcha[index];
            var value = int.Parse(c.ToString());
            var nextIndex = index + 1;
            if (nextIndex >= captcha.Length) {
                nextIndex = 0;
            }
            var nextValue = int.Parse(captcha[nextIndex].ToString());
            if (value == nextValue) {
                sum += value;
            }
        }
        return sum;
    }
}