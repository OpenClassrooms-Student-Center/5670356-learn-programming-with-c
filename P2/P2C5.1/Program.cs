string urlString = "";
int numberOfArguments;

if (args == null)
{
    numberOfArguments = 0;
}
else
{
    numberOfArguments = args.Length;
}

// assign a value to urlString or exit
switch (numberOfArguments)
{
    case 0:
        urlString = AskForUrl();
        break;
    case 1:
        urlString = args[0];
        break;
    default:
        Console.WriteLine("Please run the program with the desired URL or no argument at all");
        Environment.Exit(-1);
        break;
}

Console.WriteLine("Checking URL " + urlString);

if (IsValidURL(urlString))
{
    Console.WriteLine(urlString + " is a well-formed URL");
}
else
{
    Console.WriteLine(urlString + " is not a well-formed URL");
}

/// <summary>
/// Prompt user for URL
/// </summary>
/// <returns>Prompt user for URL</returns>
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