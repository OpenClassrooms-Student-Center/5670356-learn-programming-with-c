namespace P2C5._3;

public class WriteFile
{
    /// <summary>
    /// Writes the contents of a string to a file
    /// </summary>
    /// <param name="content">The content to write to a file</param>
    /// <param name="fileName">The name of the output file</param>
    public static void WriteToFile(string content, string fileName)
    {
        try
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine("Content written to " + fileName);
        }
        catch (IOException e)
        {
            Console.WriteLine("Could not write to file " + fileName + " " + e.ToString());
        }
    }
}
