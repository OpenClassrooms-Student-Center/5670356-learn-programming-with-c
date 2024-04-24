IDictionary<string, int> months = new Dictionary<string, int>();

// TODO: replace names with constant (final) String variables
months.Add("June", 6);
months.Add("September", 9);
months.Add("March", 5);

// TODO: Fix March with the proper value (3)


// TODO: Remove June


// Display the contents of the dictionary
Console.WriteLine("This is our ingredients list:");
foreach (KeyValuePair<string, int> keyPair in months)
{
    Console.WriteLine(keyPair.Key.ToString() + " is month number " + keyPair.Value + " of the year ");
}