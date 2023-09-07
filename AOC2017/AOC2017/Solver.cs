public class Solver
{
    public int SolveWithNext(string captcha)
    {
        return Solve(captcha, 1);
    }
    
    public int SolveHalfWay(string captcha)
    {
        return Solve(captcha, captcha.Length / 2);
    }
    
    private int Solve(string captcha, int indexOffset)
    {
        var sum = 0;
        var maxIndex = captcha.Length - 1;
        for (var index = 0; index < captcha.Length; index++) {
            var character = captcha[index];
            var value = int.Parse(character.ToString());
            var nextIndex = index + indexOffset > maxIndex 
                ? maxIndex - index + indexOffset - 1
                : index + indexOffset;

            var nextChar = captcha[nextIndex];
            var nextValue = int.Parse(nextChar.ToString());
            if (value == nextValue) {
                sum += value;
            }
        }
        return sum;
    }
    
    public void SolveAndPrint(string captcha)
    {
        Console.WriteLine(SolveWithNext(captcha));
    }
}