namespace P2C4._3;

public class SimpleMath
{
    // <summary>
    /// Displays the average temperature from values provided as command-line arguments
    /// </summary>
    /// <param name="args">space-separated list of temperatures</param>
    public static int CalculateAverage(List<int> listOfIntegers)
    {
        int average = 0;

        foreach (int value in listOfIntegers)
        {
            average += value;
        }
        average /= listOfIntegers.Count;

        return average;
    }
}
