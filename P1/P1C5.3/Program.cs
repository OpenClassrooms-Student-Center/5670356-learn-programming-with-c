ISet<string> ingredients = new HashSet<string>();
ingredients.Add("sugar");
ingredients.Add("chocolate");
ingredients.Add("butter");
ingredients.Add("vanilla");

// TODO: add another ingredient to the set


// TODO: now remove vanilla from the set


// Display the resuting set
Console.WriteLine("Here is our ingredients list");
foreach (string ingredient in ingredients)
{
    Console.WriteLine(ingredient);
}