public class Solver
{
    public int Solve(string captcha)
    {
        var sum = 0;

        for (var index = 0; index < captcha.Length; index++) {
            var character = captcha[index];
            var value = int.Parse(character.ToString());
            var nextIndex = index + 1 == captcha.Length ? 0 : index + 1;

            var nextChar = captcha[nextIndex];
            var nextValue = int.Parse(nextChar.ToString());
            if (value == nextValue) {
                sum += value;
            }
        }
        return sum;
    }
}