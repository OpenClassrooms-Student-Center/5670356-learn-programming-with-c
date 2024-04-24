//TODO
//Add the missing lines to this file to be able to access it from another class.

/// <summary>
/// Prompt user for URL
/// </summary>
/// <returns>A string representation of the URL entered by the user</returns>
public static string AskForUrl()
{
    Console.WriteLine("Please enter a valid URL");
    string url = Console.ReadLine();
    return url;
}

/// <summary>
/// Check if a string is a well-formed URL
/// </summary>
/// <param name="urlString"></param>
/// <returns>true if the URL is well formed, else false</returns>
private static bool IsValidURL(string urlString)
{
    if (Uri.IsWellFormedUriString(urlString, UriKind.Absolute))
    {
        return true;
    }
    else
    {
        return false;
    }
}
