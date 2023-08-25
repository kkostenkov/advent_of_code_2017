public class Solver
{
    public int SolveNextDigit(string captcha)
    {
        var sum = 0;
        for (var index = 0; index < captcha.Length; index++) {
            var character = captcha[index];
            char nextCharacter;
            if (index == captcha.Length - 1) {
                nextCharacter = captcha[0];
            }
            else {
                nextCharacter = captcha[index + 1];
            }
            if (character == nextCharacter) {
                sum += character - '0';
            }
        }
        return sum;
    }

    public int SolveOppositeDigit(string captcha)
    {
        var sum = 0;
        var step = captcha.Length / 2;
        for (var index = 0; index < captcha.Length; index++) {
            var character = captcha[index];
            char nextCharacter;
            if (index + step == captcha.Length - 1) {
                nextCharacter = captcha[0];
            }
            else {
                nextCharacter = captcha[captcha.Length - index];
            }
            if (character == nextCharacter) {
                sum += character - '0';
            }
        }
        return sum;
    }

    public int GetIndexInRangeAfterSteps(int totalLength, int current, int addSteps)
    {
        var result = current + addSteps;
        while (result > totalLength - 1) {
            result -= totalLength;
        }

        return result;
    }
}