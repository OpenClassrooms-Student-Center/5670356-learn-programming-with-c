using P2C2._2;

Color selectedColor = Color.Green;

// TODO: Replace the if/else sequence with an equivalent switch statement that operates according to the value of the selectedColor variable
if (selectedColor == Color.Blue)
{
    Console.WriteLine("The color is blue");
}
else if (selectedColor == Color.Green)
{
    Console.WriteLine("The color is green");
}
else if (selectedColor == Color.Red)
{
    Console.WriteLine("The color is red");
}
else if (selectedColor == Color.Yellow)
{
    Console.WriteLine("The color is yellow");
}
else
{
    Console.WriteLine("We do not know the color!");
}