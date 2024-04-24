
using P2C4._2;

List<int> recordedTemperaturesInDegreesCelcius = new List<int>();

// Fill the list from values provided as command-line arguments
foreach (string stringRepresentationOfTemperature in args)
{
    int temperature = int.Parse(stringRepresentationOfTemperature);
    recordedTemperaturesInDegreesCelcius.Add(temperature);
}

// Guard against empty list
if (recordedTemperaturesInDegreesCelcius.Count == 0)
{
    Console.WriteLine("Cannot calculate average of empty list!");
}
else
{
    // Calculate and print the average temperature
    int averageTemperature =
        SimpleMath.CalculateAverage(recordedTemperaturesInDegreesCelcius);
    Console.WriteLine("The average temperature is " + averageTemperature);
}