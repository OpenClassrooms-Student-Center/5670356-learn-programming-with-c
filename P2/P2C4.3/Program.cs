using P2C4._3;

List<int> recordedTemperaturesInDegreesCelcius = new List<int>();

// Fill the list from values provided as command-line arguments
foreach (string stringRepresentationOfTemperature in args)
{
    int temperature = int.Parse(stringRepresentationOfTemperature);
    recordedTemperaturesInDegreesCelcius.Add(temperature);
}

// Calculate and print the average temperature
int averageTemperature = SimpleMath.CalculateAverage(recordedTemperaturesInDegreesCelcius);
Console.WriteLine("The average temperature is " + averageTemperature);