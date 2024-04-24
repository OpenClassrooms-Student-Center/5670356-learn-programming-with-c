using P2C5._3;
using System.Net;

string urlString = UserInput.AskForUrl();

string content = GetContent(urlString);

try
{
    WriteFile.WriteToFile(content, "output.txt");
}
catch (IOException e)
{
    Console.WriteLine("Could not write file - " + e.ToString());
}

/// <summary>
/// Return the content from the URL
/// </summary>
/// <param name="url">The web address of the network resource</param>
static string GetContent(string url)
{
    string content = "";

    try
    {
        using (WebClient webClient = new WebClient())
        {
            content = webClient.DownloadString(url);
        }
    }
    catch (WebException e)
    {
        Console.WriteLine("Cannot establish connection - " + e.ToString());
    }

    return content;
}