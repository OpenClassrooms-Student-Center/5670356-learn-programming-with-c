
using P2C2._1;

/// <summary>
/// This displays:
/// - a personalized Hello message if an argument has been sent when running the program
/// - The traditional "Hello world!" message if not
/// </summary>
/// <remarks>Created by the OpenClassrooms Education Team</remarks>

if (args.Count() == 1)
{
    ConditionnalHello.SayHelloTo(args[0]);
}
else
{
    ConditionnalHello.SayHelloTo("world");
}

