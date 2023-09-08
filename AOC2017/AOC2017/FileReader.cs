public class FileReader
{
    public string Read(string path)
    {
        var relativePath = Path.Combine(Directory.GetCurrentDirectory(), path);
        var text = File.ReadAllText(relativePath);
        return text;
    }
}