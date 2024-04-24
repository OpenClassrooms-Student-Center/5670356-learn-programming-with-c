using P2C2._2;

Color selectedColor = Color.green;

// TODO: Replace the if/else sequence with an equivalent switch statement that operates according to the value of the selectedColor variable
if (selectedColor == Color.blue)
{
    Console.WriteLine("The color is blue");
}
else if (selectedColor == Color.green)
{
    Console.WriteLine("The color is green");
}
else if (selectedColor == Color.red)
{
    Console.WriteLine("The color is red");
}
else if (selectedColor == Color.yellow)
{
    Console.WriteLine("The color is yellow");
}
else
{
    Console.WriteLine("We do not know the color!");
}