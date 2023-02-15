using System.IO;
using System.Text;

public static class Logs
{
    private static string fileWrites = "";

    public static void WriteText(string message)
    {
        fileWrites += message + "\n";
        using (var sw = new StreamWriter($"logs.txt", false, Encoding.UTF8))
        {
            sw.WriteLine(fileWrites);
        }
    }
}