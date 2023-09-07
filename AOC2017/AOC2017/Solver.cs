public class Solver
{
    public int SolveWithNext(string captcha)
    {
        return Solve(captcha, 1);
    }
    
    private int Solve(string captcha, int indexOffset)
    {
        var sum = 0;

        for (var index = 0; index < captcha.Length; index++) {
            var character = captcha[index];
            var value = int.Parse(character.ToString());
            var nextIndex = index + indexOffset == captcha.Length ? 0 : index + indexOffset;

            var nextChar = captcha[nextIndex];
            var nextValue = int.Parse(nextChar.ToString());
            if (value == nextValue) {
                sum += value;
            }
        }
        return sum;
    }
    
    // private int GetIndex

    public void SolveAndPrint(string captcha)
    {
        Console.WriteLine(SolveWithNext(captcha));
    }
}