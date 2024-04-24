// define the string representation of the URL to connect to
using System.Net;

string urlString = UserInput.AskForUrl();

Console.WriteLine(GetContent(urlString));

/// <summary>
/// Return the content from the URL
/// </summary>
/// <param name="url">The web address from which content will be returned</param>
string GetContent(string url)
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