public class Solver
{
    public int Solve(string captcha)
    {
        var digits = captcha.Split().Select(s => int.Parse(s)).ToList();
        var sum = 0;
        for (int i = 0; i < digits.Count; i++) {
            var digit = digits[i];
            sum += digit;
        }
        return sum;
    }
}